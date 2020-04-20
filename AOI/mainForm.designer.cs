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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tbMargin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbExposureTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbSizeThr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbEdgeThr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbDiffThr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCOM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbParallel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnOriginScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOriginScanStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowseOrigin = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbOriginFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTestScanStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnTestScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbTestFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBrowseTest = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCompare = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCompareStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInverseComopsitional = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPhaseCorrelation = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbLowResolution = new MaterialSkin.Controls.MaterialCheckBox();
            this.reportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowseGcode = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbGcodeFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gcodeFileMaterialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.toolTipReport = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStop = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(503, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 507);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.tableLayoutPanel10);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(268, 276);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.materialLabel11, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel13, 0, 6);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel12, 0, 5);
            this.tableLayoutPanel10.Controls.Add(this.tbMargin, 1, 4);
            this.tableLayoutPanel10.Controls.Add(this.tbExposureTime, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.tbSizeThr, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.tbEdgeThr, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.tbDiffThr, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel5, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel6, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel7, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.tbCOM, 1, 5);
            this.tableLayoutPanel10.Controls.Add(this.tbParallel, 1, 6);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 7;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(254, 245);
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
            this.materialLabel11.Location = new System.Drawing.Point(3, 136);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(163, 34);
            this.materialLabel11.TabIndex = 53;
            this.materialLabel11.Text = "Margin";
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
            this.materialLabel13.Location = new System.Drawing.Point(3, 204);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(163, 41);
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
            this.materialLabel12.Location = new System.Drawing.Point(3, 170);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(163, 34);
            this.materialLabel12.TabIndex = 54;
            this.materialLabel12.Text = "Serial Port";
            // 
            // tbMargin
            // 
            this.tbMargin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMargin.Depth = 0;
            this.tbMargin.Hint = "";
            this.tbMargin.Location = new System.Drawing.Point(172, 139);
            this.tbMargin.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMargin.Name = "tbMargin";
            this.tbMargin.PasswordChar = '\0';
            this.tbMargin.SelectedText = "";
            this.tbMargin.SelectionLength = 0;
            this.tbMargin.SelectionStart = 0;
            this.tbMargin.Size = new System.Drawing.Size(79, 23);
            this.tbMargin.TabIndex = 15;
            this.tbMargin.TabStop = false;
            this.tbMargin.Text = "50";
            this.tbMargin.UseSystemPasswordChar = false;
            // 
            // tbExposureTime
            // 
            this.tbExposureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExposureTime.Depth = 0;
            this.tbExposureTime.Hint = "";
            this.tbExposureTime.Location = new System.Drawing.Point(172, 105);
            this.tbExposureTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbExposureTime.Name = "tbExposureTime";
            this.tbExposureTime.PasswordChar = '\0';
            this.tbExposureTime.SelectedText = "";
            this.tbExposureTime.SelectionLength = 0;
            this.tbExposureTime.SelectionStart = 0;
            this.tbExposureTime.Size = new System.Drawing.Size(79, 23);
            this.tbExposureTime.TabIndex = 14;
            this.tbExposureTime.TabStop = false;
            this.tbExposureTime.Text = "1200";
            this.tbExposureTime.UseSystemPasswordChar = false;
            // 
            // tbSizeThr
            // 
            this.tbSizeThr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSizeThr.Depth = 0;
            this.tbSizeThr.Hint = "";
            this.tbSizeThr.Location = new System.Drawing.Point(172, 71);
            this.tbSizeThr.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSizeThr.Name = "tbSizeThr";
            this.tbSizeThr.PasswordChar = '\0';
            this.tbSizeThr.SelectedText = "";
            this.tbSizeThr.SelectionLength = 0;
            this.tbSizeThr.SelectionStart = 0;
            this.tbSizeThr.Size = new System.Drawing.Size(79, 23);
            this.tbSizeThr.TabIndex = 13;
            this.tbSizeThr.TabStop = false;
            this.tbSizeThr.Text = "600";
            this.tbSizeThr.UseSystemPasswordChar = false;
            // 
            // tbEdgeThr
            // 
            this.tbEdgeThr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEdgeThr.Depth = 0;
            this.tbEdgeThr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdgeThr.Hint = "";
            this.tbEdgeThr.Location = new System.Drawing.Point(172, 37);
            this.tbEdgeThr.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbEdgeThr.Name = "tbEdgeThr";
            this.tbEdgeThr.PasswordChar = '\0';
            this.tbEdgeThr.SelectedText = "";
            this.tbEdgeThr.SelectionLength = 0;
            this.tbEdgeThr.SelectionStart = 0;
            this.tbEdgeThr.Size = new System.Drawing.Size(79, 23);
            this.tbEdgeThr.TabIndex = 12;
            this.tbEdgeThr.TabStop = false;
            this.tbEdgeThr.Text = "3";
            this.tbEdgeThr.UseSystemPasswordChar = false;
            // 
            // tbDiffThr
            // 
            this.tbDiffThr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiffThr.Depth = 0;
            this.tbDiffThr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiffThr.Hint = "";
            this.tbDiffThr.Location = new System.Drawing.Point(172, 3);
            this.tbDiffThr.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbDiffThr.Name = "tbDiffThr";
            this.tbDiffThr.PasswordChar = '\0';
            this.tbDiffThr.SelectedText = "";
            this.tbDiffThr.SelectionLength = 0;
            this.tbDiffThr.SelectionStart = 0;
            this.tbDiffThr.Size = new System.Drawing.Size(79, 23);
            this.tbDiffThr.TabIndex = 11;
            this.tbDiffThr.TabStop = false;
            this.tbDiffThr.Text = "30";
            this.tbDiffThr.UseSystemPasswordChar = false;
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
            this.materialLabel4.Size = new System.Drawing.Size(163, 34);
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
            this.materialLabel5.Location = new System.Drawing.Point(3, 34);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(163, 34);
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
            this.materialLabel6.Location = new System.Drawing.Point(3, 68);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(163, 34);
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
            this.materialLabel7.Location = new System.Drawing.Point(3, 102);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(163, 34);
            this.materialLabel7.TabIndex = 49;
            this.materialLabel7.Text = "Exposure Time";
            // 
            // tbCOM
            // 
            this.tbCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCOM.Depth = 0;
            this.tbCOM.Hint = "";
            this.tbCOM.Location = new System.Drawing.Point(172, 173);
            this.tbCOM.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCOM.Name = "tbCOM";
            this.tbCOM.PasswordChar = '\0';
            this.tbCOM.SelectedText = "";
            this.tbCOM.SelectionLength = 0;
            this.tbCOM.SelectionStart = 0;
            this.tbCOM.Size = new System.Drawing.Size(79, 23);
            this.tbCOM.TabIndex = 16;
            this.tbCOM.TabStop = false;
            this.tbCOM.Text = "COM4";
            this.tbCOM.UseSystemPasswordChar = false;
            // 
            // tbParallel
            // 
            this.tbParallel.Depth = 0;
            this.tbParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParallel.Hint = "";
            this.tbParallel.Location = new System.Drawing.Point(172, 207);
            this.tbParallel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbParallel.Name = "tbParallel";
            this.tbParallel.PasswordChar = '\0';
            this.tbParallel.SelectedText = "";
            this.tbParallel.SelectionLength = 0;
            this.tbParallel.SelectionStart = 0;
            this.tbParallel.Size = new System.Drawing.Size(58, 23);
            this.tbParallel.TabIndex = 17;
            this.tbParallel.TabStop = false;
            this.tbParallel.Text = "4";
            this.tbParallel.UseSystemPasswordChar = false;
            // 
            // btnOriginScan
            // 
            this.btnOriginScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOriginScan.AutoSize = true;
            this.btnOriginScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOriginScan.Depth = 0;
            this.btnOriginScan.Location = new System.Drawing.Point(380, 3);
            this.btnOriginScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOriginScan.Name = "btnOriginScan";
            this.btnOriginScan.Primary = true;
            this.btnOriginScan.Size = new System.Drawing.Size(64, 26);
            this.btnOriginScan.TabIndex = 3;
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
            this.btnOriginScanStop.Location = new System.Drawing.Point(451, 6);
            this.btnOriginScanStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOriginScanStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOriginScanStop.Name = "btnOriginScanStop";
            this.btnOriginScanStop.Primary = false;
            this.btnOriginScanStop.Size = new System.Drawing.Size(18, 20);
            this.btnOriginScanStop.TabIndex = 4;
            this.btnOriginScanStop.Text = "■";
            this.toolTipStop.SetToolTip(this.btnOriginScanStop, "Stop");
            this.btnOriginScanStop.UseVisualStyleBackColor = true;
            this.btnOriginScanStop.Click += new System.EventHandler(this.BtnOriginScanStop_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.Controls.Add(this.btnOriginScanStop, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnBrowseOrigin, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnOriginScan, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbOriginFolder, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 47);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(473, 32);
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
            this.btnBrowseOrigin.Location = new System.Drawing.Point(311, 6);
            this.btnBrowseOrigin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseOrigin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseOrigin.Name = "btnBrowseOrigin";
            this.btnBrowseOrigin.Primary = false;
            this.btnBrowseOrigin.Size = new System.Drawing.Size(62, 20);
            this.btnBrowseOrigin.TabIndex = 2;
            this.btnBrowseOrigin.Text = "Browse";
            this.btnBrowseOrigin.UseVisualStyleBackColor = true;
            this.btnBrowseOrigin.Click += new System.EventHandler(this.BtnBrowseOrigin_Click);
            // 
            // tbOriginFolder
            // 
            this.tbOriginFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOriginFolder.Depth = 0;
            this.tbOriginFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOriginFolder.Hint = "";
            this.tbOriginFolder.Location = new System.Drawing.Point(3, 3);
            this.tbOriginFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbOriginFolder.Name = "tbOriginFolder";
            this.tbOriginFolder.PasswordChar = '\0';
            this.tbOriginFolder.SelectedText = "";
            this.tbOriginFolder.SelectionLength = 0;
            this.tbOriginFolder.SelectionStart = 0;
            this.tbOriginFolder.Size = new System.Drawing.Size(301, 23);
            this.tbOriginFolder.TabIndex = 1;
            this.tbOriginFolder.TabStop = false;
            this.tbOriginFolder.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.Controls.Add(this.btnTestScanStop, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnTestScan, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbTestFolder, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnBrowseTest, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 113);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(473, 32);
            this.tableLayoutPanel6.TabIndex = 52;
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
            this.btnTestScanStop.Location = new System.Drawing.Point(451, 6);
            this.btnTestScanStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTestScanStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestScanStop.Name = "btnTestScanStop";
            this.btnTestScanStop.Primary = false;
            this.btnTestScanStop.Size = new System.Drawing.Size(18, 20);
            this.btnTestScanStop.TabIndex = 8;
            this.btnTestScanStop.Text = "■";
            this.toolTipStop.SetToolTip(this.btnTestScanStop, "Stop");
            this.btnTestScanStop.UseVisualStyleBackColor = true;
            this.btnTestScanStop.Click += new System.EventHandler(this.BtnTestScanStop_Click);
            // 
            // btnTestScan
            // 
            this.btnTestScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestScan.AutoSize = true;
            this.btnTestScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestScan.Depth = 0;
            this.btnTestScan.Location = new System.Drawing.Point(380, 3);
            this.btnTestScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestScan.Name = "btnTestScan";
            this.btnTestScan.Primary = true;
            this.btnTestScan.Size = new System.Drawing.Size(64, 26);
            this.btnTestScan.TabIndex = 7;
            this.btnTestScan.Text = "Scan";
            this.btnTestScan.UseVisualStyleBackColor = true;
            this.btnTestScan.Click += new System.EventHandler(this.BtnTestScan_Click);
            // 
            // tbTestFolder
            // 
            this.tbTestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTestFolder.Depth = 0;
            this.tbTestFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTestFolder.Hint = "";
            this.tbTestFolder.Location = new System.Drawing.Point(3, 3);
            this.tbTestFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTestFolder.Name = "tbTestFolder";
            this.tbTestFolder.PasswordChar = '\0';
            this.tbTestFolder.SelectedText = "";
            this.tbTestFolder.SelectionLength = 0;
            this.tbTestFolder.SelectionStart = 0;
            this.tbTestFolder.Size = new System.Drawing.Size(301, 23);
            this.tbTestFolder.TabIndex = 5;
            this.tbTestFolder.TabStop = false;
            this.tbTestFolder.UseSystemPasswordChar = false;
            // 
            // btnBrowseTest
            // 
            this.btnBrowseTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTest.AutoSize = true;
            this.btnBrowseTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseTest.Depth = 0;
            this.btnBrowseTest.Location = new System.Drawing.Point(311, 6);
            this.btnBrowseTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseTest.Name = "btnBrowseTest";
            this.btnBrowseTest.Primary = false;
            this.btnBrowseTest.Size = new System.Drawing.Size(62, 20);
            this.btnBrowseTest.TabIndex = 6;
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
            this.materialLabel2.Location = new System.Drawing.Point(5, 25);
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
            this.materialLabel3.Location = new System.Drawing.Point(6, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 51;
            this.materialLabel3.Text = "Test Folder";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.btnCompare, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnCompareStop, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(8, 134);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(197, 32);
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
            this.btnCompare.Size = new System.Drawing.Size(92, 26);
            this.btnCompare.TabIndex = 21;
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
            this.btnCompareStop.Location = new System.Drawing.Point(102, 6);
            this.btnCompareStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompareStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompareStop.Name = "btnCompareStop";
            this.btnCompareStop.Primary = false;
            this.btnCompareStop.Size = new System.Drawing.Size(91, 20);
            this.btnCompareStop.TabIndex = 22;
            this.btnCompareStop.Text = "■";
            this.toolTipStop.SetToolTip(this.btnCompareStop, "Stop");
            this.btnCompareStop.UseVisualStyleBackColor = true;
            this.btnCompareStop.Click += new System.EventHandler(this.BtnCompareStop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.rbInverseComopsitional);
            this.groupBox3.Controls.Add(this.rbPhaseCorrelation);
            this.groupBox3.Controls.Add(this.cbLowResolution);
            this.groupBox3.Controls.Add(this.tableLayoutPanel9);
            this.groupBox3.Location = new System.Drawing.Point(286, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 276);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compare";
            // 
            // rbInverseComopsitional
            // 
            this.rbInverseComopsitional.AutoSize = true;
            this.rbInverseComopsitional.Depth = 0;
            this.rbInverseComopsitional.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbInverseComopsitional.Location = new System.Drawing.Point(11, 55);
            this.rbInverseComopsitional.Margin = new System.Windows.Forms.Padding(0);
            this.rbInverseComopsitional.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbInverseComopsitional.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbInverseComopsitional.Name = "rbInverseComopsitional";
            this.rbInverseComopsitional.Ripple = true;
            this.rbInverseComopsitional.Size = new System.Drawing.Size(167, 30);
            this.rbInverseComopsitional.TabIndex = 19;
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
            this.rbPhaseCorrelation.Location = new System.Drawing.Point(11, 25);
            this.rbPhaseCorrelation.Margin = new System.Windows.Forms.Padding(0);
            this.rbPhaseCorrelation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPhaseCorrelation.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPhaseCorrelation.Name = "rbPhaseCorrelation";
            this.rbPhaseCorrelation.Ripple = true;
            this.rbPhaseCorrelation.Size = new System.Drawing.Size(139, 30);
            this.rbPhaseCorrelation.TabIndex = 18;
            this.rbPhaseCorrelation.TabStop = true;
            this.rbPhaseCorrelation.Text = "Phase Correlation";
            this.rbPhaseCorrelation.UseVisualStyleBackColor = true;
            // 
            // cbLowResolution
            // 
            this.cbLowResolution.AutoSize = true;
            this.cbLowResolution.Depth = 0;
            this.cbLowResolution.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbLowResolution.Location = new System.Drawing.Point(11, 94);
            this.cbLowResolution.Margin = new System.Windows.Forms.Padding(0);
            this.cbLowResolution.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbLowResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbLowResolution.Name = "cbLowResolution";
            this.cbLowResolution.Ripple = true;
            this.cbLowResolution.Size = new System.Drawing.Size(184, 30);
            this.cbLowResolution.TabIndex = 20;
            this.cbLowResolution.Text = "Low Resolution Compare";
            this.cbLowResolution.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.materialContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "About";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.btnBrowseGcode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbGcodeFile, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 182);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(473, 32);
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
            this.btnBrowseGcode.Location = new System.Drawing.Point(406, 6);
            this.btnBrowseGcode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseGcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseGcode.Name = "btnBrowseGcode";
            this.btnBrowseGcode.Primary = false;
            this.btnBrowseGcode.Size = new System.Drawing.Size(63, 20);
            this.btnBrowseGcode.TabIndex = 10;
            this.btnBrowseGcode.Text = "Browse";
            this.btnBrowseGcode.UseVisualStyleBackColor = true;
            this.btnBrowseGcode.Click += new System.EventHandler(this.BtnBrowseGcode_Click);
            // 
            // tbGcodeFile
            // 
            this.tbGcodeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGcodeFile.Depth = 0;
            this.tbGcodeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGcodeFile.Hint = "";
            this.tbGcodeFile.Location = new System.Drawing.Point(3, 3);
            this.tbGcodeFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbGcodeFile.Name = "tbGcodeFile";
            this.tbGcodeFile.PasswordChar = '\0';
            this.tbGcodeFile.SelectedText = "";
            this.tbGcodeFile.SelectionLength = 0;
            this.tbGcodeFile.SelectionStart = 0;
            this.tbGcodeFile.Size = new System.Drawing.Size(396, 23);
            this.tbGcodeFile.TabIndex = 9;
            this.tbGcodeFile.TabStop = false;
            this.tbGcodeFile.UseSystemPasswordChar = false;
            // 
            // gcodeFileMaterialLabel1
            // 
            this.gcodeFileMaterialLabel1.AutoSize = true;
            this.gcodeFileMaterialLabel1.Depth = 0;
            this.gcodeFileMaterialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.gcodeFileMaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gcodeFileMaterialLabel1.Location = new System.Drawing.Point(6, 157);
            this.gcodeFileMaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.gcodeFileMaterialLabel1.Name = "gcodeFileMaterialLabel1";
            this.gcodeFileMaterialLabel1.Size = new System.Drawing.Size(86, 19);
            this.gcodeFileMaterialLabel1.TabIndex = 50;
            this.gcodeFileMaterialLabel1.Text = "G Code File";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gcodeFileMaterialLabel1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 225);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSaveSettings.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveSettings.IconColor = System.Drawing.Color.Green;
            this.btnSaveSettings.IconSize = 24;
            this.btnSaveSettings.Location = new System.Drawing.Point(923, 29);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnSaveSettings.Rotation = 0D;
            this.btnSaveSettings.Size = new System.Drawing.Size(28, 28);
            this.btnSaveSettings.TabIndex = 24;
            this.toolTipSave.SetToolTip(this.btnSaveSettings, "Save Settings");
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnReport.IconColor = System.Drawing.Color.Green;
            this.btnReport.IconSize = 24;
            this.btnReport.Location = new System.Drawing.Point(889, 29);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnReport.Rotation = 0D;
            this.btnReport.Size = new System.Drawing.Size(28, 28);
            this.btnReport.TabIndex = 23;
            this.toolTipReport.SetToolTip(this.btnReport, "Get Report");
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnHelp.IconColor = System.Drawing.Color.Green;
            this.btnHelp.IconSize = 24;
            this.btnHelp.Location = new System.Drawing.Point(957, 29);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnHelp.Rotation = 0D;
            this.btnHelp.Size = new System.Drawing.Size(28, 28);
            this.btnHelp.TabIndex = 25;
            this.toolTipHelp.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 595);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbMargin;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbExposureTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbSizeThr;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbEdgeThr;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbDiffThr;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCOM;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbParallel;
        private MaterialSkin.Controls.MaterialRaisedButton btnOriginScan;
        private MaterialSkin.Controls.MaterialFlatButton btnOriginScanStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public MaterialSkin.Controls.MaterialSingleLineTextField tbOriginFolder;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowseOrigin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public MaterialSkin.Controls.MaterialSingleLineTextField tbTestFolder;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowseTest;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnTestScan;
        private MaterialSkin.Controls.MaterialFlatButton btnTestScanStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompare;
        private MaterialSkin.Controls.MaterialFlatButton btnCompareStop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog reportSaveFileDialog;
        private MaterialSkin.Controls.MaterialCheckBox cbLowResolution;
        private MaterialSkin.Controls.MaterialRadioButton rbInverseComopsitional;
        private MaterialSkin.Controls.MaterialRadioButton rbPhaseCorrelation;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowseGcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbGcodeFile;
        private MaterialSkin.Controls.MaterialLabel gcodeFileMaterialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconButton btnSaveSettings;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnHelp;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.ToolTip toolTipReport;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.ToolTip toolTipStop;
    }
}

