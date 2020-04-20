using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Basler.Pylon;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Reflection;

namespace AOI
{
    public partial class mainForm : MaterialForm
    {
        int rows_count;
        int cols_count;
        int ims_count = -1;

        MaterialSkinManager msm = MaterialSkinManager.Instance;

        Thread threadOriginScan;
        Thread threadTestScan;
        Thread threadCompare;

        private delegate void SolveDelegate();

        Camera camera = null;

        public static List<Patch> patches;

        // Use ParallelOptions instance to store the CancellationToken
        ParallelOptions po = new ParallelOptions();
        CancellationTokenSource cts;

        public mainForm()
        {
            InitializeComponent();
        }

        private void ShowPatch(object sender, EventArgs e, int col, int row)
        {
            userCompareForm frm_patch = new userCompareForm();

            Patch p = patches.Find(t => t.row == row && t.col == col);

            Bitmap origin = new Bitmap(tbOriginFolder.Text + $"\\{p.im_number}.bmp");
            frm_patch.pictureBox1.Image = origin;


            Bitmap result = new Bitmap(tbTestFolder.Text + $"\\Result\\{p.im_number}.bmp");
            frm_patch.pictureBox2.Image = result;
            //result.Dispose();

            frm_patch.im_number = p.im_number;
            frm_patch.parent = this;
            frm_patch.Show();
        }

        public void BeforeProcessPatch(int im_number)
        {
            if (this.InvokeRequired)
            {
                SolveDelegate del = new SolveDelegate(() => BeforeProcessPatch(im_number)); //delegate
                this.Invoke(del); //call
            }
            else
            {
                Patch p = patches.Find(t => t.im_number == im_number);
                Button btnTemp = (Button)tableLayoutPanel1.GetControlFromPosition(p.col, p.row);
                btnTemp.FlatAppearance.BorderColor = Color.Orange;
                btnTemp.BackgroundImage = Properties.Resources.loading;
            }
        }

        public void AfterProcessPatch(int im_number, int result)
        {
            if (this.InvokeRequired)
            {
                SolveDelegate del = new SolveDelegate(() => AfterProcessPatch(im_number, result)); //delegate
                this.Invoke(del); //call
            }
            else
            {
                Patch p = patches.Find(t => t.im_number == im_number);
                Button btnTemp = (Button)tableLayoutPanel1.GetControlFromPosition(p.col, p.row);

                if (result == 1) // success
                {
                    btnTemp.FlatAppearance.BorderColor = Color.Green;
                }
                else if (result == 0) // miss
                {
                    btnTemp.FlatAppearance.BorderColor = Color.Red;
                }

                btnTemp.Enabled = true;

                string OutputfileAdrress = tbTestFolder.Text + $"\\Result\\{im_number}.bmp";
                btnTemp.BackgroundImageLayout = ImageLayout.Zoom;
                btnTemp.BackgroundImage = new Bitmap(OutputfileAdrress);
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public void ComparePatch(int im_number)
        {
            po.CancellationToken.ThrowIfCancellationRequested();
            int defect_finding_result;
            String origin_image_address;
            String test_image_address;
            String diff_image_address;
            String transform_file_address;
            String result_image_address;
            String defects_data_file_path;
            origin_image_address = tbOriginFolder.Text + $"/{im_number}.bmp";
            test_image_address = tbTestFolder.Text + $"/{im_number}.bmp";
            transform_file_address = tbTestFolder.Text + $"/Difference/{im_number}-tr.txt";
            diff_image_address = tbTestFolder.Text + $"/Difference/{im_number}.bmp";
            result_image_address = tbTestFolder.Text + $"/Result/{im_number}.bmp";
            defects_data_file_path = tbTestFolder.Text + $"/Result/defects-data/{im_number}-dd.txt";

            if (File.Exists(origin_image_address) && File.Exists(test_image_address))
            {
                try
                {
                    BeforeProcessPatch(im_number);

                    #region Step1
                    // For finding working directory
                    //string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    //Directory.SetCurrentDirectory(exeDir);

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    if (rbPhaseCorrelation.Checked)
                    {
                        startInfo.FileName = @"POCShift.exe";
                        if (cbLowResolution.Checked)
                            startInfo.Arguments = startInfo.Arguments = $"{correct_quotes(test_image_address)} {correct_quotes(origin_image_address)} {correct_quotes(transform_file_address)} half-size";
                        else
                            startInfo.Arguments = startInfo.Arguments = $"{correct_quotes(test_image_address)} {correct_quotes(origin_image_address)} {correct_quotes(transform_file_address)}";
                    }
                    else if (rbInverseComopsitional.Checked)
                    {
                        startInfo.FileName = @"inverse_compositional.exe";
                        if (cbLowResolution.Checked)
                        {
                            startInfo.Arguments = $"{test_image_address} {origin_image_address} {transform_file_address} -h 1";
                        }
                        else
                        {
                            startInfo.Arguments = $"{test_image_address} {origin_image_address} {transform_file_address}";
                        }
                    }
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;
                    Process process = new Process();
                    process.StartInfo = startInfo;
                    process.EnableRaisingEvents = true;
                    process.Start();
                    process.WaitForExit();
                    #endregion

                    #region Step2
                    startInfo = new ProcessStartInfo();
                    startInfo.FileName = @"inverse_compositional_output.exe";
                    if (cbLowResolution.Checked)
                    {
                        startInfo.Arguments = $"{test_image_address} {origin_image_address} {diff_image_address} {transform_file_address} 1";
                    }
                    else
                    {
                        startInfo.Arguments = $"{test_image_address} {origin_image_address} {diff_image_address} {transform_file_address}";
                    }
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;
                    process = new Process();
                    process.StartInfo = startInfo;
                    process.EnableRaisingEvents = true;
                    process.Start();
                    process.WaitForExit();
                    #endregion

                    #region Step3
                    File.Delete(result_image_address);
                    startInfo = new ProcessStartInfo();
                    startInfo.FileName = @"postprocess.exe";
                    startInfo.Arguments = $"{diff_image_address} {test_image_address} {result_image_address} " +
                        $"{tbDiffThr.Text} {tbEdgeThr.Text} {tbSizeThr.Text} " +
                        $"{tbMargin.Text} {tbMargin.Text} {tbMargin.Text} {tbMargin.Text}";

                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;

                    process = new Process();
                    process.StartInfo = startInfo;
                    process.EnableRaisingEvents = true;
                    process.Start();
                    process.WaitForExit();
                    defect_finding_result = process.ExitCode; // 1: Defectless  0: Nondefectless

                    Directory.CreateDirectory(tbTestFolder.Text + "/Result/user-actions/");
                    StreamWriter user_decision_writer = new StreamWriter(tbTestFolder.Text + "/Result/user-actions/" + im_number.ToString() + "-ud.txt");
                    if (defect_finding_result == 1)
                        user_decision_writer.WriteLine("undecidable");
                    else
                        user_decision_writer.WriteLine("keep");
                    user_decision_writer.Flush();
                    user_decision_writer.Close();
                    #endregion

                    AfterProcessPatch(im_number, defect_finding_result);
                }
                catch (OperationCanceledException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void Compare()
        {
            if (validate_all_inputs() == false)
                return;
            Directory.CreateDirectory(tbTestFolder.Text + "\\Difference");
            Directory.CreateDirectory(tbTestFolder.Text + "\\Result");

            ShowGrid();

            int parallel = Convert.ToInt32(tbParallel.Text);
            cts = new CancellationTokenSource();
            po.CancellationToken = cts.Token;
            po.MaxDegreeOfParallelism = Environment.ProcessorCount;

            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= ims_count; i++) queue.Enqueue(i);
            try
            {
                Parallel.For(0, ims_count, po, (i) =>
                {
                    ComparePatch(queue.Dequeue());
                });
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            CompareStop();
        }
        public void InitCamera()
        {
            // Create a camera object that selects the first camera device found.
            // More constructors are available for selecting a specific camera device.
            camera = new Camera();

            // Print the model name of the camera.
            Console.WriteLine("Using camera {0}.", camera.CameraInfo[CameraInfoKey.ModelName]);

            // Set the acquisition mode to free running continuous acquisition when the camera is opened.
            camera.CameraOpened += Configuration.AcquireSingleFrame;

            // Open the connection to the camera device.
            camera.Open();

            // The parameter MaxNumBuffer can be used to control the amount of buffers
            // allocated for grabbing. The default value of this parameter is 10.
            camera.Parameters[PLCameraInstance.MaxNumBuffer].SetValue(2);
            camera.Parameters[PLUsbCamera.PixelFormat].SetValue(PLUsbCamera.PixelFormat.RGB8);
            camera.Parameters[PLUsbCamera.ExposureTime].SetValue(Convert.ToInt32(tbExposureTime.Text));
            camera.Parameters[PLUsbCamera.ExposureAuto].SetValue(PLUsbCamera.ExposureAuto.Off);
            camera.Parameters[PLUsbCamera.GainAuto].SetValue(PLUsbCamera.GainAuto.Off);
            camera.Parameters[PLUsbCamera.BalanceWhiteAuto].SetValue(PLUsbCamera.BalanceWhiteAuto.Off);
            //camera.Parameters[PLPixelDataConverter.OutputBitAlignment].SetValue(PLPixelDataConverter.OutputBitAlignment.LsbAligned);
        }
        public void GrabImage(string filename)
        {
            camera.StreamGrabber.Start();

            IGrabResult grabResult = camera.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
            using (grabResult)
            {
                // Image grabbed successfully?
                if (grabResult.GrabSucceeded)
                {
                    // Access the image data.
                    Console.WriteLine("SizeX: {0}", grabResult.Width);
                    Console.WriteLine("SizeY: {0}", grabResult.Height);
                    byte[] buffer = grabResult.PixelData as byte[];
                    Console.WriteLine("Gray value of first pixel: {0}", buffer[0]);
                    Console.WriteLine("");

                    //####### Display Method 1 ##############
                    // Display the grabbed image.
                    ImageWindow.DisplayImage(0, grabResult);

                    //####### Display Method 2 : Convert to C# Image #########
                    Bitmap bmp = ConvertArrayToImage(buffer, grabResult.Width, grabResult.Height, grabResult);
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    bmp.Save(filename);
                }
                else
                {
                    Console.WriteLine("Error: {0} {1}", grabResult.ErrorCode, grabResult.ErrorDescription);
                    MessageBox.Show("Error : " + grabResult.ErrorDescription);
                    MessageBox.Show("test");
                }
            }
            camera.StreamGrabber.Stop();
        }
        private Bitmap ConvertArrayToImage(byte[] buffer, int width, int height, IGrabResult grabResult)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            // Lock the bits of the bitmap.
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

            byte swap;
            for (int h = 0; h < height; h++)
            {
                int startIndex = h * bmpData.Stride;
                for (int w = 0; w < width; w++)
                {
                    swap = buffer[startIndex + 3 * w + 0];
                    buffer[startIndex + 3 * w + 0] = buffer[startIndex + 3 * w + 2];
                    buffer[startIndex + 3 * w + 2] = swap;
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(buffer, 0, bmpData.Scan0, bmpData.Stride * bitmap.Height);
            bitmap.UnlockBits(bmpData);
            return bitmap;
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(
                Primary.Green800,
                Primary.Green900,
                Primary.Green500,
                Accent.LightBlue200,
                TextShade.WHITE);

            StreamReader sr = new StreamReader("default_parameters.txt");
            tbDiffThr.Text = sr.ReadLine();
            tbEdgeThr.Text = sr.ReadLine();
            tbSizeThr.Text = sr.ReadLine();
            tbExposureTime.Text = sr.ReadLine();
            tbMargin.Text = sr.ReadLine();
            tbCOM.Text = sr.ReadLine();
            tbParallel.Text = sr.ReadLine();
            tbGcodeFile.Text = sr.ReadLine();
            tbOriginFolder.Text = sr.ReadLine();
            tbTestFolder.Text = sr.ReadLine();
            sr.Close();
        }
        private void BtnOriginScan_Click(object sender, EventArgs e)
        {
            if (threadOriginScan == null)
            {
                Calirate();
                threadOriginScan = new Thread(() => Scan("origin"));
                threadOriginScan.Start();
                btnOriginScan.Text = "Pause";
            }
            else if (threadOriginScan.ThreadState == System.Threading.ThreadState.Suspended)
            {
                threadOriginScan.Resume();
                btnOriginScan.Text = "Pause";
            }
            else //if ThreadState == Running
            {
                threadOriginScan.Suspend();
                btnOriginScan.Text = "Resume";
            }
        }
        private void ShowGrid()
        {
            if (this.InvokeRequired)
            {
                SolveDelegate del = new SolveDelegate(ShowGrid); //delegate
                this.Invoke(del); //call
            }
            else
            {
                int even_odd_row = 0;
                int col = 0;
                int row = 0;
                int im_number = 0;

                read_gcode_file(tbGcodeFile.Text);

                tableLayoutPanel1.Controls.Clear();

                tableLayoutPanel1.ColumnStyles.Clear();
                tableLayoutPanel1.RowStyles.Clear();

                tableLayoutPanel1.ColumnCount = Convert.ToInt32(cols_count);
                tableLayoutPanel1.RowCount = Convert.ToInt32(rows_count);

                for (int c = 0; c < cols_count; c++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / cols_count));

                    for (int r = 0; r < rows_count; r++)
                    {
                        if (c == 0)
                        {
                            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rows_count));
                        }

                        Button btn = new Button();
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 2;
                        btn.BackgroundImageLayout = ImageLayout.Center;
                        btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left);
                        btn.Margin = new Padding(0);

                        btn.Enabled = false;

                        int cc = c;
                        int rr = r;

                        btn.Click += new EventHandler((_sender, _event) => ShowPatch(_sender, _event, cc, rr));

                        tableLayoutPanel1.Controls.Add(btn, c, r);
                        im_number++;
                    }
                }

                patches = new List<Patch>();

                for (int i = 1; i <= im_number; i++)
                {
                    patches.Add(new Patch(col, row, i));

                    if (even_odd_row == 0)
                    {
                        col++;
                        if (col >= cols_count)
                        {
                            row++;
                            even_odd_row = 1;
                            col--;
                        }
                    }
                    else if (even_odd_row == 1)
                    {
                        col--;
                        if (col < 0)
                        {
                            row++;
                            even_odd_row = 0;
                            col++;
                        }
                    }
                }
            }
        }

        private void BtnBrowseGcode_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.gcode";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbGcodeFile.Text = openFileDialog1.FileName;
                ShowGrid();
            }
        }

        private void Calirate()
        {
            SerialPort sp = new SerialPort(tbCOM.Text, 250000);
            try
            {
                sp.Open();
                StreamReader gcodeFile = new StreamReader(tbGcodeFile.Text);

                string line;
                for (int i = 0; i < 8; i++)
                {
                    line = gcodeFile.ReadLine();
                    sp.WriteLine(line);
                }

                sp.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBrowseOrigin_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                tbOriginFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnBrowseTest_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                tbTestFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            if (validate_all_inputs() == false)
                return;
            btnCompareStop.Enabled = true;
            btnCompare.Enabled = false;

            threadCompare = null;
            threadCompare = new Thread(Compare);
            threadCompare.Start();
        }

        private void Scan(string mode)
        {
            SerialPort sp = new SerialPort(tbCOM.Text, 250000);
            try
            {
                InitCamera();
                sp.Open();

                string line;
                StreamReader gcodeFile = new StreamReader(tbGcodeFile.Text);
                for (int i = 0; i < 4; i++)
                {
                    line = gcodeFile.ReadLine();
                }
                int im_number = 1;

                sp.WriteLine("M106");

                while (true)
                {
                    while (true)
                    {
                        line = gcodeFile.ReadLine();
                        if (line == null) break;
                        if (line.Trim().Length == 0) continue;
                        break;
                    }
                    if (line == null) break;

                    sp.WriteLine(line);

                    //Console.WriteLine(sp.ReadLine());
                    //do
                    //{
                    //    x = sp.ReadLine();
                    //    y = x.CompareTo("echo:Done");
                    //} while (y != 0);

                    Thread.Sleep(2000);

                    if (mode == "origin")
                    {
                        if (!Directory.Exists(tbOriginFolder.Text))
                            Directory.CreateDirectory(tbOriginFolder.Text);
                        GrabImage(tbOriginFolder.Text + "\\" + im_number + ".bmp");
                    }
                    else if (mode == "test")
                    {
                        if (!Directory.Exists(tbTestFolder.Text))
                            Directory.CreateDirectory(tbTestFolder.Text);
                        GrabImage(tbTestFolder.Text + "\\" + im_number + ".bmp");
                    }
                    //sp.ReadLine();
                    im_number++;
                }

                sp.WriteLine("M107");

                Console.WriteLine("im_number : " + im_number);

                sp.WriteLine("G0 X0.000  Y0.000");

                gcodeFile.Close();
                sp.Close();
                camera.Close();

                if (mode == "origin")
                {
                    OriginScanStop();
                }
                else if (mode == "test")
                {
                    TestScanStop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnTestScan_Click(object sender, EventArgs e)
        {
            if (threadTestScan == null)
            {
                Calirate();
                threadTestScan = new Thread(() => Scan("test"));
                threadTestScan.Start();
                btnTestScan.Text = "Pause";
            }
            else if (threadTestScan.ThreadState == System.Threading.ThreadState.Suspended)
            {
                threadTestScan.Resume();
                btnTestScan.Text = "Pause";
            }
            else //if ThreadState == Running
            {
                threadTestScan.Suspend();
                btnTestScan.Text = "Resume";
            }
        }

        public void CompareStop()
        {
            if (this.InvokeRequired)
            {
                SolveDelegate del = new SolveDelegate(CompareStop); //delegate
                this.Invoke(del); //call
            }
            else
            {
                cts.Cancel();
                threadCompare.Abort();
                btnCompareStop.Enabled = false;
                btnCompare.Enabled = true;
            }
        }

        public void TestScanStop()
        {
            if (this.InvokeRequired)
            {
                SolveDelegate del = new SolveDelegate(TestScanStop); //delegate
                this.Invoke(del); //call
            }
            else
            {
                btnTestScanStop.Enabled = false;
                threadTestScan.Suspend();
                threadTestScan = null;
                btnTestScan.Text = "Scan";
            }
        }

        public void OriginScanStop()
        {
            if (this.InvokeRequired)
            {
                SolveDelegate del = new SolveDelegate(OriginScanStop); //delegate
                this.Invoke(del); //call
            }
            else
            {
                btnTestScanStop.Enabled = false;
                threadOriginScan.Abort();
                btnOriginScan.Text = "Scan";
            }
        }

        private void BtnCompareStop_Click(object sender, EventArgs e)
        {
            CompareStop();
        }

        private void BtnTestScanStop_Click(object sender, EventArgs e)
        {
            TestScanStop();
        }

        private void BtnOriginScanStop_Click(object sender, EventArgs e)
        {
            OriginScanStop();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadCompare != null)
            {
                threadCompare.Abort();
                threadCompare = null;
            }
            if (threadOriginScan != null)
            {
                threadOriginScan.Abort();
                threadOriginScan = null;
            }
            if (threadTestScan != null)
            {
                threadTestScan.Abort();
                threadTestScan = null;
            }
            if (cts != null)
            {
                cts.Dispose();
            }
        }
     
        public bool read_gcode_file(string gcode_file_path)
        {
            StreamReader gcode_file_reader = new StreamReader(tbGcodeFile.Text);
            string[] values = gcode_file_reader.ReadLine().Split(' ');
            gcode_file_reader.Close();
            if (values.Length != 2)
                return false;
            if (is_integer(values[0]) == false || is_integer(values[1]) == false)
                return false;
            try
            {
                cols_count = Convert.ToInt32(values[0]);
                rows_count = Convert.ToInt32(values[1]);
                ims_count = cols_count * rows_count;
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public string correct_quotes(string arg)
        {
            int pos1 = 0;
            int pos2 = arg.Length - 1;
            while (arg[pos1] == '"') pos1++;
            while (arg[pos2] == '"') pos2--;
            return "\"" + arg.Substring(pos1, pos2 - pos1 + 1) + "\"";
        }
        public bool is_all_whitespaces(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ' && s[i] != '\t' && s[i] != '\n')
                    return false;
            return true;
        }
        public bool validate_all_inputs(int input_codes_bitmask = 0)
        {
            List<string> messages; messages = new List<string>(40);
            List<int> messages_codes; messages_codes = new List<int>(40);

            if (is_all_whitespaces(tbOriginFolder.Text))
                messages.Add("Please enter origin images folder address.");
            else if (!Directory.Exists(tbOriginFolder.Text))
                messages.Add("Origin images folder does not exist.");
            else if (Directory.GetFiles(tbOriginFolder.Text).Length == 0)
                messages.Add("Origin images folder is empty.");

            if (is_all_whitespaces(tbTestFolder.Text))
                messages.Add("Please enter test images folder address.");
            else if (!Directory.Exists(tbTestFolder.Text))
                messages.Add("Test images folder does not exist.");
            else if (Directory.GetFiles(tbTestFolder.Text).Length == 0)
                messages.Add("Test images folder is empty.");

            if (is_all_whitespaces(tbGcodeFile.Text))
                messages.Add("Please enter gcode file address.");
            else if (!File.Exists(tbGcodeFile.Text))
                messages.Add("gcode file does not exist.");
            else if (read_gcode_file(tbGcodeFile.Text) == false)
                messages.Add("Cannot obtain number of images from gcode file. The format of gcode is incorrect.");

            string main_message = "";
            for (int i = 0; i < messages.Count; i++)
                main_message += messages[i] + "\n";
            if (main_message == "")
                return true;
            MessageBox.Show(main_message);
            return false;
        }
        public bool validate_report_inputs(int input_codes_bitmask = 0)
        {
            List<string> messages; messages = new List<string>(40);
            List<int> messages_codes; messages_codes = new List<int>(40);
            if (ims_count > -1)
                return true;
            if (is_all_whitespaces(tbGcodeFile.Text))
                messages.Add("Please enter gcode file address to read number of images.");
            else if (!File.Exists(tbGcodeFile.Text))
                messages.Add("gcode file does not exist to read number of images.");
            else if (read_gcode_file(tbGcodeFile.Text) == false)
                messages.Add("Cannot obtain number of images from gcode file. The format of gcode is incorrect.");

            string main_message = "";
            for (int i = 0; i < messages.Count; i++)
                main_message += messages[i] + "\n";
            if (main_message == "")
                return true;
            MessageBox.Show(main_message);
            return false;
        }
        public bool is_integer(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] < '0' || s[i] > '9')
                    return false;
            return true;
        }
        public int get_ims_count()
        {
            if (ims_count == -1 && validate_report_inputs() == true)
                read_gcode_file(tbGcodeFile.Text);
            return ims_count;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("default_parameters.txt");

            sw.WriteLine(tbDiffThr.Text);
            sw.WriteLine(tbEdgeThr.Text);
            sw.WriteLine(tbSizeThr.Text);
            sw.WriteLine(tbExposureTime.Text);

            sw.WriteLine(tbMargin.Text);
            sw.WriteLine(tbCOM.Text);
            sw.WriteLine(tbParallel.Text);

            sw.WriteLine(tbGcodeFile.Text);
            sw.WriteLine(tbOriginFolder.Text);
            sw.WriteLine(tbTestFolder.Text);

            sw.Flush();
            sw.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (validate_report_inputs() && reportSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string report_path = reportSaveFileDialog.FileName;
                    StreamWriter main_report_writer = new StreamWriter(report_path);
                    for (int i = 1; i <= get_ims_count(); i++)
                    {
                        main_report_writer.Write("Image #" + i.ToString() + ":");
                        StreamReader sr;
                        string user_decision = "keep";
                        if (File.Exists(tbTestFolder.Text + "/Result/user-actions/" + i.ToString() + "-ud.txt"))
                        {
                            sr = new StreamReader(tbTestFolder.Text + "/Result/user-actions/" + i.ToString() + "-ud.txt");
                            user_decision = sr.ReadLine();
                            sr.Close();
                        }
                        if (user_decision == "keep")
                        {
                            StreamReader report_reader = new StreamReader(tbTestFolder.Text + "/Result/defects-data/" + i.ToString() + "-dd.txt");
                            report_reader.ReadLine(); // Skip first line (Hint)
                            int defects_count = Convert.ToInt32(report_reader.ReadLine());
                            main_report_writer.Write(" " + defects_count.ToString() + " defects\n");
                            for (int j = 0; j < defects_count; j++)
                            {
                                string[] vals = report_reader.ReadLine().Split(' ');
                                main_report_writer.WriteLine("  " + vals[0] + " at [" + vals[1] + ", " + vals[2] + "]");
                                //MessageBox.Show(vals[1]);
                            }
                            report_reader.Close();
                        }
                        else
                            main_report_writer.WriteLine();
                        main_report_writer.WriteLine();
                    }
                    main_report_writer.Flush();
                    main_report_writer.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
