namespace AOI
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetDefault = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBottom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTop = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLeft = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtExposureTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSizeThr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEdgeThr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDiffThr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCOM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtParallel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOriginScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOriginScanStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowseOrigin = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtOriginFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTestFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBrowseTest = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTestScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTestScanStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCompare = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCompareStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInverseComopsitional = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPhaseCorrelation = new MaterialSkin.Controls.MaterialRadioButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.reportMaterialRaisedButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbLowResolution = new MaterialSkin.Controls.MaterialCheckBox();
            this.reportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip3 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip4 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalirate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowseGcode = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtGcodeFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gcodeFileMaterialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gCodeGenerationMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gCodeGenerationMethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(299, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 616);
            this.tableLayoutPanel1.TabIndex = 39;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.tableLayoutPanel11);
            this.groupBox2.Controls.Add(this.tableLayoutPanel10);
            this.groupBox2.Location = new System.Drawing.Point(807, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 381);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.btnSetDefault, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(18, 333);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(245, 32);
            this.tableLayoutPanel11.TabIndex = 49;
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDefault.AutoSize = true;
            this.btnSetDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetDefault.Depth = 0;
            this.btnSetDefault.Location = new System.Drawing.Point(3, 3);
            this.btnSetDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Primary = true;
            this.btnSetDefault.Size = new System.Drawing.Size(239, 26);
            this.btnSetDefault.TabIndex = 0;
            this.btnSetDefault.Text = "Set Default";
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.BtnSetDefault_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.materialLabel11, 0, 7);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel13, 0, 9);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel12, 0, 8);
            this.tableLayoutPanel10.Controls.Add(this.txtBottom, 1, 7);
            this.tableLayoutPanel10.Controls.Add(this.txtTop, 1, 6);
            this.tableLayoutPanel10.Controls.Add(this.txtRight, 1, 5);
            this.tableLayoutPanel10.Controls.Add(this.txtLeft, 1, 4);
            this.tableLayoutPanel10.Controls.Add(this.txtExposureTime, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.txtSizeThr, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.txtEdgeThr, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.txtDiffThr, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel5, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel6, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel7, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel8, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel9, 0, 5);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel10, 0, 6);
            this.tableLayoutPanel10.Controls.Add(this.txtCOM, 1, 8);
            this.tableLayoutPanel10.Controls.Add(this.txtParallel, 1, 9);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(18, 25);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 10;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(245, 302);
            this.tableLayoutPanel10.TabIndex = 37;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(3, 210);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(157, 30);
            this.materialLabel11.TabIndex = 53;
            this.materialLabel11.Text = "Bottom";
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(3, 270);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(157, 32);
            this.materialLabel13.TabIndex = 55;
            this.materialLabel13.Text = "# of Parallel Tasks";
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(3, 240);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(157, 30);
            this.materialLabel12.TabIndex = 54;
            this.materialLabel12.Text = "Serial Port";
            // 
            // txtBottom
            // 
            this.txtBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBottom.Depth = 0;
            this.txtBottom.Hint = "";
            this.txtBottom.Location = new System.Drawing.Point(166, 213);
            this.txtBottom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.PasswordChar = '\0';
            this.txtBottom.SelectedText = "";
            this.txtBottom.SelectionLength = 0;
            this.txtBottom.SelectionStart = 0;
            this.txtBottom.Size = new System.Drawing.Size(76, 23);
            this.txtBottom.TabIndex = 47;
            this.txtBottom.TabStop = false;
            this.txtBottom.Text = "50";
            this.txtBottom.UseSystemPasswordChar = false;
            // 
            // txtTop
            // 
            this.txtTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTop.Depth = 0;
            this.txtTop.Hint = "";
            this.txtTop.Location = new System.Drawing.Point(166, 183);
            this.txtTop.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTop.Name = "txtTop";
            this.txtTop.PasswordChar = '\0';
            this.txtTop.SelectedText = "";
            this.txtTop.SelectionLength = 0;
            this.txtTop.SelectionStart = 0;
            this.txtTop.Size = new System.Drawing.Size(76, 23);
            this.txtTop.TabIndex = 47;
            this.txtTop.TabStop = false;
            this.txtTop.Text = "50";
            this.txtTop.UseSystemPasswordChar = false;
            // 
            // txtRight
            // 
            this.txtRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRight.Depth = 0;
            this.txtRight.Hint = "";
            this.txtRight.Location = new System.Drawing.Point(166, 153);
            this.txtRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRight.Name = "txtRight";
            this.txtRight.PasswordChar = '\0';
            this.txtRight.SelectedText = "";
            this.txtRight.SelectionLength = 0;
            this.txtRight.SelectionStart = 0;
            this.txtRight.Size = new System.Drawing.Size(76, 23);
            this.txtRight.TabIndex = 47;
            this.txtRight.TabStop = false;
            this.txtRight.Text = "50";
            this.txtRight.UseSystemPasswordChar = false;
            // 
            // txtLeft
            // 
            this.txtLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeft.Depth = 0;
            this.txtLeft.Hint = "";
            this.txtLeft.Location = new System.Drawing.Point(166, 123);
            this.txtLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.PasswordChar = '\0';
            this.txtLeft.SelectedText = "";
            this.txtLeft.SelectionLength = 0;
            this.txtLeft.SelectionStart = 0;
            this.txtLeft.Size = new System.Drawing.Size(76, 23);
            this.txtLeft.TabIndex = 47;
            this.txtLeft.TabStop = false;
            this.txtLeft.Text = "50";
            this.txtLeft.UseSystemPasswordChar = false;
            // 
            // txtExposureTime
            // 
            this.txtExposureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExposureTime.Depth = 0;
            this.txtExposureTime.Hint = "";
            this.txtExposureTime.Location = new System.Drawing.Point(166, 93);
            this.txtExposureTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtExposureTime.Name = "txtExposureTime";
            this.txtExposureTime.PasswordChar = '\0';
            this.txtExposureTime.SelectedText = "";
            this.txtExposureTime.SelectionLength = 0;
            this.txtExposureTime.SelectionStart = 0;
            this.txtExposureTime.Size = new System.Drawing.Size(76, 23);
            this.txtExposureTime.TabIndex = 47;
            this.txtExposureTime.TabStop = false;
            this.txtExposureTime.Text = "1200";
            this.txtExposureTime.UseSystemPasswordChar = false;
            // 
            // txtSizeThr
            // 
            this.txtSizeThr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSizeThr.Depth = 0;
            this.txtSizeThr.Hint = "";
            this.txtSizeThr.Location = new System.Drawing.Point(166, 63);
            this.txtSizeThr.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSizeThr.Name = "txtSizeThr";
            this.txtSizeThr.PasswordChar = '\0';
            this.txtSizeThr.SelectedText = "";
            this.txtSizeThr.SelectionLength = 0;
            this.txtSizeThr.SelectionStart = 0;
            this.txtSizeThr.Size = new System.Drawing.Size(76, 23);
            this.txtSizeThr.TabIndex = 47;
            this.txtSizeThr.TabStop = false;
            this.txtSizeThr.Text = "600";
            this.txtSizeThr.UseSystemPasswordChar = false;
            // 
            // txtEdgeThr
            // 
            this.txtEdgeThr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdgeThr.Depth = 0;
            this.txtEdgeThr.Hint = "";
            this.txtEdgeThr.Location = new System.Drawing.Point(166, 33);
            this.txtEdgeThr.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEdgeThr.Name = "txtEdgeThr";
            this.txtEdgeThr.PasswordChar = '\0';
            this.txtEdgeThr.SelectedText = "";
            this.txtEdgeThr.SelectionLength = 0;
            this.txtEdgeThr.SelectionStart = 0;
            this.txtEdgeThr.Size = new System.Drawing.Size(76, 23);
            this.txtEdgeThr.TabIndex = 47;
            this.txtEdgeThr.TabStop = false;
            this.txtEdgeThr.Text = "3";
            this.txtEdgeThr.UseSystemPasswordChar = false;
            // 
            // txtDiffThr
            // 
            this.txtDiffThr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiffThr.Depth = 0;
            this.txtDiffThr.Hint = "";
            this.txtDiffThr.Location = new System.Drawing.Point(166, 3);
            this.txtDiffThr.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiffThr.Name = "txtDiffThr";
            this.txtDiffThr.PasswordChar = '\0';
            this.txtDiffThr.SelectedText = "";
            this.txtDiffThr.SelectionLength = 0;
            this.txtDiffThr.SelectionStart = 0;
            this.txtDiffThr.Size = new System.Drawing.Size(76, 23);
            this.txtDiffThr.TabIndex = 46;
            this.txtDiffThr.TabStop = false;
            this.txtDiffThr.Text = "30";
            this.txtDiffThr.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(157, 30);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "Gray Diff. Threshold";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 30);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(157, 30);
            this.materialLabel5.TabIndex = 47;
            this.materialLabel5.Text = "Edge Threshold";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 60);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(157, 30);
            this.materialLabel6.TabIndex = 48;
            this.materialLabel6.Text = "Area Threshold";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(3, 90);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(157, 30);
            this.materialLabel7.TabIndex = 49;
            this.materialLabel7.Text = "Exposure Time";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 120);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(157, 30);
            this.materialLabel8.TabIndex = 50;
            this.materialLabel8.Text = "Left";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 150);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(157, 30);
            this.materialLabel9.TabIndex = 51;
            this.materialLabel9.Text = "Right";
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(3, 180);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(157, 30);
            this.materialLabel10.TabIndex = 52;
            this.materialLabel10.Text = "Top";
            // 
            // txtCOM
            // 
            this.txtCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCOM.Depth = 0;
            this.txtCOM.Hint = "";
            this.txtCOM.Location = new System.Drawing.Point(166, 243);
            this.txtCOM.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCOM.Name = "txtCOM";
            this.txtCOM.PasswordChar = '\0';
            this.txtCOM.SelectedText = "";
            this.txtCOM.SelectionLength = 0;
            this.txtCOM.SelectionStart = 0;
            this.txtCOM.Size = new System.Drawing.Size(76, 23);
            this.txtCOM.TabIndex = 50;
            this.txtCOM.TabStop = false;
            this.txtCOM.Text = "COM4";
            this.txtCOM.UseSystemPasswordChar = false;
            // 
            // txtParallel
            // 
            this.txtParallel.Depth = 0;
            this.txtParallel.Hint = "";
            this.txtParallel.Location = new System.Drawing.Point(166, 273);
            this.txtParallel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtParallel.Name = "txtParallel";
            this.txtParallel.PasswordChar = '\0';
            this.txtParallel.SelectedText = "";
            this.txtParallel.SelectionLength = 0;
            this.txtParallel.SelectionStart = 0;
            this.txtParallel.Size = new System.Drawing.Size(58, 23);
            this.txtParallel.TabIndex = 54;
            this.txtParallel.TabStop = false;
            this.txtParallel.Text = "4";
            this.txtParallel.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnOriginScan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOriginScanStop, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 85);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 32);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // btnOriginScan
            // 
            this.btnOriginScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOriginScan.AutoSize = true;
            this.btnOriginScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOriginScan.Depth = 0;
            this.btnOriginScan.Location = new System.Drawing.Point(3, 3);
            this.btnOriginScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOriginScan.Name = "btnOriginScan";
            this.btnOriginScan.Primary = true;
            this.btnOriginScan.Size = new System.Drawing.Size(117, 26);
            this.btnOriginScan.TabIndex = 46;
            this.btnOriginScan.Text = "Scan";
            this.btnOriginScan.UseVisualStyleBackColor = true;
            this.btnOriginScan.Click += new System.EventHandler(this.BtnOriginScan_Click);
            // 
            // btnOriginScanStop
            // 
            this.btnOriginScanStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOriginScanStop.AutoSize = true;
            this.btnOriginScanStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOriginScanStop.Depth = 0;
            this.btnOriginScanStop.Enabled = false;
            this.btnOriginScanStop.Location = new System.Drawing.Point(127, 6);
            this.btnOriginScanStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOriginScanStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOriginScanStop.Name = "btnOriginScanStop";
            this.btnOriginScanStop.Primary = false;
            this.btnOriginScanStop.Size = new System.Drawing.Size(115, 20);
            this.btnOriginScanStop.TabIndex = 48;
            this.btnOriginScanStop.Text = "Stop";
            this.btnOriginScanStop.UseVisualStyleBackColor = true;
            this.btnOriginScanStop.Click += new System.EventHandler(this.BtnOriginScanStop_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btnBrowseOrigin, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtOriginFolder, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(18, 47);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(245, 32);
            this.tableLayoutPanel5.TabIndex = 50;
            // 
            // btnBrowseOrigin
            // 
            this.btnBrowseOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOrigin.AutoSize = true;
            this.btnBrowseOrigin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseOrigin.Depth = 0;
            this.btnBrowseOrigin.Location = new System.Drawing.Point(167, 6);
            this.btnBrowseOrigin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseOrigin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseOrigin.Name = "btnBrowseOrigin";
            this.btnBrowseOrigin.Primary = false;
            this.btnBrowseOrigin.Size = new System.Drawing.Size(74, 20);
            this.btnBrowseOrigin.TabIndex = 47;
            this.btnBrowseOrigin.Text = "Browse";
            this.btnBrowseOrigin.UseVisualStyleBackColor = true;
            this.btnBrowseOrigin.Click += new System.EventHandler(this.BtnBrowseOrigin_Click);
            // 
            // txtOriginFolder
            // 
            this.txtOriginFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOriginFolder.Depth = 0;
            this.txtOriginFolder.Hint = "";
            this.txtOriginFolder.Location = new System.Drawing.Point(3, 3);
            this.txtOriginFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOriginFolder.Name = "txtOriginFolder";
            this.txtOriginFolder.PasswordChar = '\0';
            this.txtOriginFolder.SelectedText = "";
            this.txtOriginFolder.SelectionLength = 0;
            this.txtOriginFolder.SelectionStart = 0;
            this.txtOriginFolder.Size = new System.Drawing.Size(157, 23);
            this.txtOriginFolder.TabIndex = 46;
            this.txtOriginFolder.TabStop = false;
            this.txtOriginFolder.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.txtTestFolder, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnBrowseTest, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 156);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(245, 32);
            this.tableLayoutPanel6.TabIndex = 52;
            // 
            // txtTestFolder
            // 
            this.txtTestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestFolder.Depth = 0;
            this.txtTestFolder.Hint = "";
            this.txtTestFolder.Location = new System.Drawing.Point(3, 3);
            this.txtTestFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTestFolder.Name = "txtTestFolder";
            this.txtTestFolder.PasswordChar = '\0';
            this.txtTestFolder.SelectedText = "";
            this.txtTestFolder.SelectionLength = 0;
            this.txtTestFolder.SelectionStart = 0;
            this.txtTestFolder.Size = new System.Drawing.Size(157, 23);
            this.txtTestFolder.TabIndex = 46;
            this.txtTestFolder.TabStop = false;
            this.txtTestFolder.UseSystemPasswordChar = false;
            // 
            // btnBrowseTest
            // 
            this.btnBrowseTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTest.AutoSize = true;
            this.btnBrowseTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseTest.Depth = 0;
            this.btnBrowseTest.Location = new System.Drawing.Point(167, 6);
            this.btnBrowseTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseTest.Name = "btnBrowseTest";
            this.btnBrowseTest.Primary = false;
            this.btnBrowseTest.Size = new System.Drawing.Size(74, 20);
            this.btnBrowseTest.TabIndex = 47;
            this.btnBrowseTest.Text = "Browse";
            this.btnBrowseTest.UseVisualStyleBackColor = true;
            this.btnBrowseTest.Click += new System.EventHandler(this.BtnBrowseTest_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(18, 25);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "Origin Folder";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 134);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 51;
            this.materialLabel3.Text = "Test Folder";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.btnTestScan, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnTestScanStop, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(18, 194);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(245, 32);
            this.tableLayoutPanel7.TabIndex = 47;
            // 
            // btnTestScan
            // 
            this.btnTestScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestScan.AutoSize = true;
            this.btnTestScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestScan.Depth = 0;
            this.btnTestScan.Location = new System.Drawing.Point(3, 3);
            this.btnTestScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestScan.Name = "btnTestScan";
            this.btnTestScan.Primary = true;
            this.btnTestScan.Size = new System.Drawing.Size(116, 26);
            this.btnTestScan.TabIndex = 46;
            this.btnTestScan.Text = "Scan";
            this.btnTestScan.UseVisualStyleBackColor = true;
            this.btnTestScan.Click += new System.EventHandler(this.BtnTestScan_Click);
            // 
            // btnTestScanStop
            // 
            this.btnTestScanStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestScanStop.AutoSize = true;
            this.btnTestScanStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestScanStop.Depth = 0;
            this.btnTestScanStop.Enabled = false;
            this.btnTestScanStop.Location = new System.Drawing.Point(126, 6);
            this.btnTestScanStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTestScanStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestScanStop.Name = "btnTestScanStop";
            this.btnTestScanStop.Primary = false;
            this.btnTestScanStop.Size = new System.Drawing.Size(115, 20);
            this.btnTestScanStop.TabIndex = 48;
            this.btnTestScanStop.Text = "Stop";
            this.btnTestScanStop.UseVisualStyleBackColor = true;
            this.btnTestScanStop.Click += new System.EventHandler(this.BtnTestScanStop_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.btnCompare, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnCompareStop, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(18, 134);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(242, 32);
            this.tableLayoutPanel9.TabIndex = 48;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.AutoSize = true;
            this.btnCompare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompare.Depth = 0;
            this.btnCompare.Location = new System.Drawing.Point(3, 3);
            this.btnCompare.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Primary = true;
            this.btnCompare.Size = new System.Drawing.Size(115, 26);
            this.btnCompare.TabIndex = 46;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // btnCompareStop
            // 
            this.btnCompareStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompareStop.AutoSize = true;
            this.btnCompareStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompareStop.Depth = 0;
            this.btnCompareStop.Enabled = false;
            this.btnCompareStop.Location = new System.Drawing.Point(125, 6);
            this.btnCompareStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompareStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompareStop.Name = "btnCompareStop";
            this.btnCompareStop.Primary = false;
            this.btnCompareStop.Size = new System.Drawing.Size(113, 20);
            this.btnCompareStop.TabIndex = 48;
            this.btnCompareStop.Text = "Stop";
            this.btnCompareStop.UseVisualStyleBackColor = true;
            this.btnCompareStop.Click += new System.EventHandler(this.BtnCompareStop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.rbInverseComopsitional);
            this.groupBox3.Controls.Add(this.rbPhaseCorrelation);
            this.groupBox3.Controls.Add(this.tableLayoutPanel8);
            this.groupBox3.Controls.Add(this.cbLowResolution);
            this.groupBox3.Controls.Add(this.tableLayoutPanel9);
            this.groupBox3.Location = new System.Drawing.Point(807, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 229);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compare and Report";
            // 
            // rbInverseComopsitional
            // 
            this.rbInverseComopsitional.AutoSize = true;
            this.rbInverseComopsitional.Depth = 0;
            this.rbInverseComopsitional.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbInverseComopsitional.Location = new System.Drawing.Point(21, 55);
            this.rbInverseComopsitional.Margin = new System.Windows.Forms.Padding(0);
            this.rbInverseComopsitional.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbInverseComopsitional.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbInverseComopsitional.Name = "rbInverseComopsitional";
            this.rbInverseComopsitional.Ripple = true;
            this.rbInverseComopsitional.Size = new System.Drawing.Size(167, 30);
            this.rbInverseComopsitional.TabIndex = 1;
            this.rbInverseComopsitional.Text = "Inverse Compositional";
            this.rbInverseComopsitional.UseVisualStyleBackColor = true;
            // 
            // rbPhaseCorrelation
            // 
            this.rbPhaseCorrelation.AutoSize = true;
            this.rbPhaseCorrelation.Checked = true;
            this.rbPhaseCorrelation.Depth = 0;
            this.rbPhaseCorrelation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPhaseCorrelation.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbPhaseCorrelation.Location = new System.Drawing.Point(21, 25);
            this.rbPhaseCorrelation.Margin = new System.Windows.Forms.Padding(0);
            this.rbPhaseCorrelation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPhaseCorrelation.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPhaseCorrelation.Name = "rbPhaseCorrelation";
            this.rbPhaseCorrelation.Ripple = true;
            this.rbPhaseCorrelation.Size = new System.Drawing.Size(139, 30);
            this.rbPhaseCorrelation.TabIndex = 0;
            this.rbPhaseCorrelation.TabStop = true;
            this.rbPhaseCorrelation.Text = "Phase Correlation";
            this.rbPhaseCorrelation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.69421F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.reportMaterialRaisedButton, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(18, 182);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(242, 32);
            this.tableLayoutPanel8.TabIndex = 49;
            // 
            // reportMaterialRaisedButton
            // 
            this.reportMaterialRaisedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportMaterialRaisedButton.AutoSize = true;
            this.reportMaterialRaisedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportMaterialRaisedButton.Depth = 0;
            this.reportMaterialRaisedButton.Location = new System.Drawing.Point(3, 3);
            this.reportMaterialRaisedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportMaterialRaisedButton.Name = "reportMaterialRaisedButton";
            this.reportMaterialRaisedButton.Primary = true;
            this.reportMaterialRaisedButton.Size = new System.Drawing.Size(236, 26);
            this.reportMaterialRaisedButton.TabIndex = 46;
            this.reportMaterialRaisedButton.Text = "Report";
            this.reportMaterialRaisedButton.UseVisualStyleBackColor = true;
            this.reportMaterialRaisedButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // cbLowResolution
            // 
            this.cbLowResolution.AutoSize = true;
            this.cbLowResolution.Depth = 0;
            this.cbLowResolution.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbLowResolution.Location = new System.Drawing.Point(21, 94);
            this.cbLowResolution.Margin = new System.Windows.Forms.Padding(0);
            this.cbLowResolution.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbLowResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbLowResolution.Name = "cbLowResolution";
            this.cbLowResolution.Ripple = true;
            this.cbLowResolution.Size = new System.Drawing.Size(184, 30);
            this.cbLowResolution.TabIndex = 50;
            this.cbLowResolution.Text = "Low Resolution Compare";
            this.cbLowResolution.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // materialContextMenuStrip3
            // 
            this.materialContextMenuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip3.Depth = 0;
            this.materialContextMenuStrip3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip3.Name = "materialContextMenuStrip3";
            this.materialContextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // materialContextMenuStrip4
            // 
            this.materialContextMenuStrip4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip4.Depth = 0;
            this.materialContextMenuStrip4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip4.Name = "materialContextMenuStrip4";
            this.materialContextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnCalirate, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 94);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(245, 32);
            this.tableLayoutPanel4.TabIndex = 48;
            // 
            // btnCalirate
            // 
            this.btnCalirate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalirate.AutoSize = true;
            this.btnCalirate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalirate.BackColor = System.Drawing.Color.DarkRed;
            this.btnCalirate.Depth = 0;
            this.btnCalirate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCalirate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalirate.Location = new System.Drawing.Point(3, 3);
            this.btnCalirate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalirate.Name = "btnCalirate";
            this.btnCalirate.Primary = true;
            this.btnCalirate.Size = new System.Drawing.Size(239, 26);
            this.btnCalirate.TabIndex = 0;
            this.btnCalirate.Text = "Calibrate";
            this.btnCalirate.UseVisualStyleBackColor = false;
            this.btnCalirate.Click += new System.EventHandler(this.BtnCalirate_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnBrowseGcode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtGcodeFile, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(245, 32);
            this.tableLayoutPanel3.TabIndex = 47;
            // 
            // btnBrowseGcode
            // 
            this.btnBrowseGcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseGcode.AutoSize = true;
            this.btnBrowseGcode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseGcode.Depth = 0;
            this.btnBrowseGcode.Location = new System.Drawing.Point(167, 6);
            this.btnBrowseGcode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseGcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseGcode.Name = "btnBrowseGcode";
            this.btnBrowseGcode.Primary = false;
            this.btnBrowseGcode.Size = new System.Drawing.Size(74, 20);
            this.btnBrowseGcode.TabIndex = 47;
            this.btnBrowseGcode.Text = "Browse";
            this.btnBrowseGcode.UseVisualStyleBackColor = true;
            this.btnBrowseGcode.Click += new System.EventHandler(this.BtnBrowseGcode_Click);
            // 
            // txtGcodeFile
            // 
            this.txtGcodeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGcodeFile.Depth = 0;
            this.txtGcodeFile.Hint = "";
            this.txtGcodeFile.Location = new System.Drawing.Point(3, 3);
            this.txtGcodeFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGcodeFile.Name = "txtGcodeFile";
            this.txtGcodeFile.PasswordChar = '\0';
            this.txtGcodeFile.SelectedText = "";
            this.txtGcodeFile.SelectionLength = 0;
            this.txtGcodeFile.SelectionStart = 0;
            this.txtGcodeFile.Size = new System.Drawing.Size(157, 23);
            this.txtGcodeFile.TabIndex = 46;
            this.txtGcodeFile.TabStop = false;
            this.txtGcodeFile.UseSystemPasswordChar = false;
            // 
            // gcodeFileMaterialLabel1
            // 
            this.gcodeFileMaterialLabel1.AutoSize = true;
            this.gcodeFileMaterialLabel1.Depth = 0;
            this.gcodeFileMaterialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.gcodeFileMaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcodeFileMaterialLabel1.Location = new System.Drawing.Point(18, 31);
            this.gcodeFileMaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.gcodeFileMaterialLabel1.Name = "gcodeFileMaterialLabel1";
            this.gcodeFileMaterialLabel1.Size = new System.Drawing.Size(86, 19);
            this.gcodeFileMaterialLabel1.TabIndex = 50;
            this.gcodeFileMaterialLabel1.Text = "G Code File";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tableLayoutPanel7);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 265);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Images";
            // 
            // gCodeGenerationMethodGroupBox
            // 
            this.gCodeGenerationMethodGroupBox.BackColor = System.Drawing.Color.White;
            this.gCodeGenerationMethodGroupBox.Controls.Add(this.gcodeFileMaterialLabel1);
            this.gCodeGenerationMethodGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.gCodeGenerationMethodGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.gCodeGenerationMethodGroupBox.Location = new System.Drawing.Point(12, 348);
            this.gCodeGenerationMethodGroupBox.Name = "gCodeGenerationMethodGroupBox";
            this.gCodeGenerationMethodGroupBox.Size = new System.Drawing.Size(281, 345);
            this.gCodeGenerationMethodGroupBox.TabIndex = 46;
            this.gCodeGenerationMethodGroupBox.TabStop = false;
            this.gCodeGenerationMethodGroupBox.Text = "G Code";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 705);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gCodeGenerationMethodGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gCodeGenerationMethodGroupBox.ResumeLayout(false);
            this.gCodeGenerationMethodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBottom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTop;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRight;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLeft;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtExposureTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSizeThr;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEdgeThr;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiffThr;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private MaterialSkin.Controls.MaterialRaisedButton btnSetDefault;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCOM;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtParallel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnOriginScan;
        private MaterialSkin.Controls.MaterialFlatButton btnOriginScanStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtOriginFolder;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowseOrigin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtTestFolder;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowseTest;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialRaisedButton btnTestScan;
        private MaterialSkin.Controls.MaterialFlatButton btnTestScanStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompare;
        private MaterialSkin.Controls.MaterialFlatButton btnCompareStop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialRaisedButton reportMaterialRaisedButton;
        private System.Windows.Forms.SaveFileDialog reportSaveFileDialog;
        private MaterialSkin.Controls.MaterialCheckBox cbLowResolution;
        private MaterialSkin.Controls.MaterialRadioButton rbInverseComopsitional;
        private MaterialSkin.Controls.MaterialRadioButton rbPhaseCorrelation;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnCalirate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowseGcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGcodeFile;
        private MaterialSkin.Controls.MaterialLabel gcodeFileMaterialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gCodeGenerationMethodGroupBox;
    }
}

