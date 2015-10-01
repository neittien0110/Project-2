namespace CPU_Z
{
    partial class formMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCPU = new System.Windows.Forms.TabPage();
            this.groupProcessor = new System.Windows.Forms.GroupBox();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.labelAssetTag = new System.Windows.Forms.Label();
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtThreadCount = new System.Windows.Forms.TextBox();
            this.txtDataWidth = new System.Windows.Forms.TextBox();
            this.labelThread = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDataWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtClock = new System.Windows.Forms.TextBox();
            this.labelExtClock = new System.Windows.Forms.Label();
            this.txtSysName = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelCaption = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.imageCPU = new System.Windows.Forms.PictureBox();
            this.tabMainBoard = new System.Windows.Forms.TabPage();
            this.groupBIOS = new System.Windows.Forms.GroupBox();
            this.txtMinor = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVersionBIOS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtManuBIOS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBaseBoard = new System.Windows.Forms.GroupBox();
            this.txtVersionBase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabGraphics = new System.Windows.Forms.TabPage();
            this.groupMemory = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPUUsage = new System.Windows.Forms.TextBox();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabDataStorage = new System.Windows.Forms.TabPage();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabCPU.SuspendLayout();
            this.groupProcessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCPU)).BeginInit();
            this.tabMainBoard.SuspendLayout();
            this.groupBIOS.SuspendLayout();
            this.groupBaseBoard.SuspendLayout();
            this.tabGraphics.SuspendLayout();
            this.groupMemory.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCPU);
            this.tabMain.Controls.Add(this.tabMainBoard);
            this.tabMain.Controls.Add(this.tabGraphics);
            this.tabMain.Controls.Add(this.tabUser);
            this.tabMain.Controls.Add(this.tabDataStorage);
            this.tabMain.Controls.Add(this.tabNetwork);
            this.tabMain.Controls.Add(this.tabAbout);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(421, 252);
            this.tabMain.TabIndex = 0;
            // 
            // tabCPU
            // 
            this.tabCPU.Controls.Add(this.groupProcessor);
            this.tabCPU.Location = new System.Drawing.Point(4, 22);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabCPU.Size = new System.Drawing.Size(413, 226);
            this.tabCPU.TabIndex = 0;
            this.tabCPU.Text = "CPU";
            this.tabCPU.UseVisualStyleBackColor = true;
            // 
            // groupProcessor
            // 
            this.groupProcessor.Controls.Add(this.txtAssetTag);
            this.groupProcessor.Controls.Add(this.labelAssetTag);
            this.groupProcessor.Controls.Add(this.txtRevision);
            this.groupProcessor.Controls.Add(this.txtLevel);
            this.groupProcessor.Controls.Add(this.txtThreadCount);
            this.groupProcessor.Controls.Add(this.txtDataWidth);
            this.groupProcessor.Controls.Add(this.labelThread);
            this.groupProcessor.Controls.Add(this.label3);
            this.groupProcessor.Controls.Add(this.labelDataWidth);
            this.groupProcessor.Controls.Add(this.label1);
            this.groupProcessor.Controls.Add(this.txtExtClock);
            this.groupProcessor.Controls.Add(this.labelExtClock);
            this.groupProcessor.Controls.Add(this.txtSysName);
            this.groupProcessor.Controls.Add(this.la);
            this.groupProcessor.Controls.Add(this.txtFamily);
            this.groupProcessor.Controls.Add(this.txtCaption);
            this.groupProcessor.Controls.Add(this.labelFamily);
            this.groupProcessor.Controls.Add(this.labelCaption);
            this.groupProcessor.Controls.Add(this.txtName);
            this.groupProcessor.Controls.Add(this.labelName);
            this.groupProcessor.Controls.Add(this.imageCPU);
            this.groupProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupProcessor.Location = new System.Drawing.Point(3, 3);
            this.groupProcessor.Name = "groupProcessor";
            this.groupProcessor.Size = new System.Drawing.Size(407, 220);
            this.groupProcessor.TabIndex = 0;
            this.groupProcessor.TabStop = false;
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Location = new System.Drawing.Point(213, 112);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(66, 20);
            this.txtAssetTag.TabIndex = 20;
            // 
            // labelAssetTag
            // 
            this.labelAssetTag.BackColor = System.Drawing.Color.Transparent;
            this.labelAssetTag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAssetTag.Location = new System.Drawing.Point(152, 109);
            this.labelAssetTag.Name = "labelAssetTag";
            this.labelAssetTag.Size = new System.Drawing.Size(55, 23);
            this.labelAssetTag.TabIndex = 19;
            this.labelAssetTag.Text = "AssetTag";
            this.labelAssetTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRevision
            // 
            this.txtRevision.Location = new System.Drawing.Point(269, 174);
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new System.Drawing.Size(130, 20);
            this.txtRevision.TabIndex = 18;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(193, 51);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(86, 20);
            this.txtLevel.TabIndex = 17;
            // 
            // txtThreadCount
            // 
            this.txtThreadCount.Location = new System.Drawing.Point(77, 145);
            this.txtThreadCount.Name = "txtThreadCount";
            this.txtThreadCount.Size = new System.Drawing.Size(120, 20);
            this.txtThreadCount.TabIndex = 16;
            // 
            // txtDataWidth
            // 
            this.txtDataWidth.Location = new System.Drawing.Point(271, 145);
            this.txtDataWidth.Name = "txtDataWidth";
            this.txtDataWidth.Size = new System.Drawing.Size(128, 20);
            this.txtDataWidth.TabIndex = 15;
            // 
            // labelThread
            // 
            this.labelThread.BackColor = System.Drawing.Color.Transparent;
            this.labelThread.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelThread.Location = new System.Drawing.Point(6, 143);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(75, 23);
            this.labelThread.TabIndex = 14;
            this.labelThread.Text = "ThreadCount";
            this.labelThread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(145, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Level";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDataWidth
            // 
            this.labelDataWidth.BackColor = System.Drawing.Color.Transparent;
            this.labelDataWidth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDataWidth.Location = new System.Drawing.Point(205, 145);
            this.labelDataWidth.Name = "labelDataWidth";
            this.labelDataWidth.Size = new System.Drawing.Size(60, 23);
            this.labelDataWidth.TabIndex = 12;
            this.labelDataWidth.Text = "DataWidth";
            this.labelDataWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(203, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Revision";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExtClock
            // 
            this.txtExtClock.Location = new System.Drawing.Point(77, 113);
            this.txtExtClock.Name = "txtExtClock";
            this.txtExtClock.Size = new System.Drawing.Size(69, 20);
            this.txtExtClock.TabIndex = 10;
            // 
            // labelExtClock
            // 
            this.labelExtClock.BackColor = System.Drawing.Color.Transparent;
            this.labelExtClock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelExtClock.Location = new System.Drawing.Point(16, 110);
            this.labelExtClock.Name = "labelExtClock";
            this.labelExtClock.Size = new System.Drawing.Size(55, 23);
            this.labelExtClock.TabIndex = 9;
            this.labelExtClock.Text = "ExtClock";
            this.labelExtClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSysName
            // 
            this.txtSysName.Location = new System.Drawing.Point(77, 175);
            this.txtSysName.Name = "txtSysName";
            this.txtSysName.Size = new System.Drawing.Size(120, 20);
            this.txtSysName.TabIndex = 8;
            // 
            // la
            // 
            this.la.BackColor = System.Drawing.Color.Transparent;
            this.la.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.la.Location = new System.Drawing.Point(9, 170);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(72, 24);
            this.la.TabIndex = 7;
            this.la.Text = "SystemName";
            this.la.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(77, 52);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(62, 20);
            this.txtFamily.TabIndex = 6;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(77, 82);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(202, 20);
            this.txtCaption.TabIndex = 5;
            // 
            // labelFamily
            // 
            this.labelFamily.BackColor = System.Drawing.Color.Transparent;
            this.labelFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFamily.Location = new System.Drawing.Point(35, 49);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(36, 23);
            this.labelFamily.TabIndex = 4;
            this.labelFamily.Text = "Family";
            this.labelFamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCaption
            // 
            this.labelCaption.BackColor = System.Drawing.Color.Transparent;
            this.labelCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCaption.Location = new System.Drawing.Point(16, 82);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(55, 23);
            this.labelCaption.TabIndex = 3;
            this.labelCaption.Text = "Caption";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(77, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.infoCPU);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelName.Location = new System.Drawing.Point(35, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageCPU
            // 
            this.imageCPU.ErrorImage = null;
            this.imageCPU.InitialImage = null;
            this.imageCPU.Location = new System.Drawing.Point(285, 22);
            this.imageCPU.Name = "imageCPU";
            this.imageCPU.Size = new System.Drawing.Size(114, 111);
            this.imageCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageCPU.TabIndex = 0;
            this.imageCPU.TabStop = false;
            this.imageCPU.WaitOnLoad = true;
            // 
            // tabMainBoard
            // 
            this.tabMainBoard.Controls.Add(this.groupBIOS);
            this.tabMainBoard.Controls.Add(this.groupBaseBoard);
            this.tabMainBoard.Location = new System.Drawing.Point(4, 22);
            this.tabMainBoard.Name = "tabMainBoard";
            this.tabMainBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainBoard.Size = new System.Drawing.Size(413, 226);
            this.tabMainBoard.TabIndex = 1;
            this.tabMainBoard.Text = "MainBoard";
            this.tabMainBoard.UseVisualStyleBackColor = true;
            // 
            // groupBIOS
            // 
            this.groupBIOS.Controls.Add(this.txtMinor);
            this.groupBIOS.Controls.Add(this.txtMajor);
            this.groupBIOS.Controls.Add(this.label11);
            this.groupBIOS.Controls.Add(this.label10);
            this.groupBIOS.Controls.Add(this.txtVersionBIOS);
            this.groupBIOS.Controls.Add(this.label9);
            this.groupBIOS.Controls.Add(this.txtManuBIOS);
            this.groupBIOS.Controls.Add(this.label8);
            this.groupBIOS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBIOS.Location = new System.Drawing.Point(3, 102);
            this.groupBIOS.Name = "groupBIOS";
            this.groupBIOS.Size = new System.Drawing.Size(407, 121);
            this.groupBIOS.TabIndex = 1;
            this.groupBIOS.TabStop = false;
            this.groupBIOS.Text = "BIOS";
            // 
            // txtMinor
            // 
            this.txtMinor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMinor.Location = new System.Drawing.Point(287, 71);
            this.txtMinor.Name = "txtMinor";
            this.txtMinor.Size = new System.Drawing.Size(94, 20);
            this.txtMinor.TabIndex = 14;
            // 
            // txtMajor
            // 
            this.txtMajor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMajor.Location = new System.Drawing.Point(97, 72);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(108, 20);
            this.txtMajor.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Major Version";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(196, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Minor Version";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVersionBIOS
            // 
            this.txtVersionBIOS.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVersionBIOS.Location = new System.Drawing.Point(97, 45);
            this.txtVersionBIOS.Name = "txtVersionBIOS";
            this.txtVersionBIOS.Size = new System.Drawing.Size(284, 20);
            this.txtVersionBIOS.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(5, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Version";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtManuBIOS
            // 
            this.txtManuBIOS.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtManuBIOS.Location = new System.Drawing.Point(97, 19);
            this.txtManuBIOS.Name = "txtManuBIOS";
            this.txtManuBIOS.Size = new System.Drawing.Size(284, 20);
            this.txtManuBIOS.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(5, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Manufacturer";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBaseBoard
            // 
            this.groupBaseBoard.Controls.Add(this.txtVersionBase);
            this.groupBaseBoard.Controls.Add(this.label7);
            this.groupBaseBoard.Controls.Add(this.txtModel);
            this.groupBaseBoard.Controls.Add(this.txtManufacturer);
            this.groupBaseBoard.Controls.Add(this.label4);
            this.groupBaseBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBaseBoard.Location = new System.Drawing.Point(3, 3);
            this.groupBaseBoard.Name = "groupBaseBoard";
            this.groupBaseBoard.Size = new System.Drawing.Size(407, 93);
            this.groupBaseBoard.TabIndex = 0;
            this.groupBaseBoard.TabStop = false;
            this.groupBaseBoard.Text = "Base Board";
            // 
            // txtVersionBase
            // 
            this.txtVersionBase.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVersionBase.Location = new System.Drawing.Point(315, 54);
            this.txtVersionBase.Name = "txtVersionBase";
            this.txtVersionBase.Size = new System.Drawing.Size(66, 20);
            this.txtVersionBase.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(5, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Model";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModel
            // 
            this.txtModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtModel.Location = new System.Drawing.Point(97, 54);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(208, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtManufacturer.Location = new System.Drawing.Point(97, 19);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(284, 20);
            this.txtManufacturer.TabIndex = 4;
            this.txtManufacturer.TextChanged += new System.EventHandler(this.infoMainBoard);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacturer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabGraphics
            // 
            this.tabGraphics.Controls.Add(this.groupMemory);
            this.tabGraphics.Location = new System.Drawing.Point(4, 22);
            this.tabGraphics.Name = "tabGraphics";
            this.tabGraphics.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphics.Size = new System.Drawing.Size(413, 226);
            this.tabGraphics.TabIndex = 2;
            this.tabGraphics.Text = "Memory";
            this.tabGraphics.UseVisualStyleBackColor = true;
            // 
            // groupMemory
            // 
            this.groupMemory.Controls.Add(this.label2);
            this.groupMemory.Controls.Add(this.txtCPUUsage);
            this.groupMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMemory.Location = new System.Drawing.Point(3, 3);
            this.groupMemory.Name = "groupMemory";
            this.groupMemory.Size = new System.Drawing.Size(407, 220);
            this.groupMemory.TabIndex = 0;
            this.groupMemory.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCPUUsage
            // 
            this.txtCPUUsage.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCPUUsage.Location = new System.Drawing.Point(93, 19);
            this.txtCPUUsage.Name = "txtCPUUsage";
            this.txtCPUUsage.Size = new System.Drawing.Size(267, 20);
            this.txtCPUUsage.TabIndex = 3;
            this.txtCPUUsage.TextChanged += new System.EventHandler(this.infoMemory);
            // 
            // tabUser
            // 
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(413, 226);
            this.tabUser.TabIndex = 3;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // tabDataStorage
            // 
            this.tabDataStorage.Location = new System.Drawing.Point(4, 22);
            this.tabDataStorage.Name = "tabDataStorage";
            this.tabDataStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataStorage.Size = new System.Drawing.Size(413, 226);
            this.tabDataStorage.TabIndex = 4;
            this.tabDataStorage.Text = "DataStorage";
            this.tabDataStorage.UseVisualStyleBackColor = true;
            // 
            // tabNetwork
            // 
            this.tabNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetwork.Size = new System.Drawing.Size(413, 226);
            this.tabNetwork.TabIndex = 5;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.label6);
            this.tabAbout.Controls.Add(this.label5);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(413, 226);
            this.tabAbout.TabIndex = 6;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bui Van Trung-CNCNTT 01 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product by";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 252);
            this.Controls.Add(this.tabMain);
            this.Name = "formMain";
            this.Text = "CPU-T";
            this.tabMain.ResumeLayout(false);
            this.tabCPU.ResumeLayout(false);
            this.groupProcessor.ResumeLayout(false);
            this.groupProcessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCPU)).EndInit();
            this.tabMainBoard.ResumeLayout(false);
            this.groupBIOS.ResumeLayout(false);
            this.groupBIOS.PerformLayout();
            this.groupBaseBoard.ResumeLayout(false);
            this.groupBaseBoard.PerformLayout();
            this.tabGraphics.ResumeLayout(false);
            this.groupMemory.ResumeLayout(false);
            this.groupMemory.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.TabPage tabMainBoard;
        private System.Windows.Forms.TabPage tabGraphics;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabDataStorage;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.GroupBox groupProcessor;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox imageCPU;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtSysName;
        private System.Windows.Forms.TextBox txtRevision;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtThreadCount;
        private System.Windows.Forms.TextBox txtDataWidth;
        private System.Windows.Forms.Label labelThread;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDataWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtClock;
        private System.Windows.Forms.Label labelExtClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.Label labelAssetTag;
        private System.Windows.Forms.GroupBox groupMemory;
        private System.Windows.Forms.GroupBox groupBIOS;
        private System.Windows.Forms.GroupBox groupBaseBoard;
        private System.Windows.Forms.TextBox txtVersionBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVersionBIOS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtManuBIOS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinor;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtCPUUsage;
        private System.Windows.Forms.Label label2;
    }
}

