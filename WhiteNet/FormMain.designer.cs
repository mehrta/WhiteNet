namespace WhiteNet
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGoToPreviousPacket = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGoToNextPacket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItem_ShowToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_ShowStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_StartCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_StopCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItem_ClearDataGridView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemNe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_NetworkInterfaces = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItem_UdpTrafficGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_IcmpTrafficGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tolMain = new System.Windows.Forms.ToolStrip();
            this.btnCaptureOptions = new System.Windows.Forms.ToolStripButton();
            this.btnStartCapture = new System.Windows.Forms.ToolStripButton();
            this.btnStopCapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFormAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.staMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgramStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblElpsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTip = new System.Windows.Forms.Panel();
            this.lnkInterfaceFound = new System.Windows.Forms.LinkLabel();
            this.lblNumberOfInterfaces = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPackets = new System.Windows.Forms.DataGridView();
            this.Col_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picDefault_First = new System.Windows.Forms.PictureBox();
            this.picDefault_Third = new System.Windows.Forms.PictureBox();
            this.picDefault_Second = new System.Windows.Forms.PictureBox();
            this.picDefault_Expand = new System.Windows.Forms.PictureBox();
            this.picDefault_Collapse = new System.Windows.Forms.PictureBox();
            this.picCollapseAll = new System.Windows.Forms.PictureBox();
            this.picExpandAll = new System.Windows.Forms.PictureBox();
            this.trePacket = new System.Windows.Forms.TreeView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatArp = new System.Windows.Forms.Label();
            this.lblStatGreV4 = new System.Windows.Forms.Label();
            this.lblStatIgmpV4 = new System.Windows.Forms.Label();
            this.lblStatIcmpV6 = new System.Windows.Forms.Label();
            this.lblStatIcmpV4 = new System.Windows.Forms.Label();
            this.lblStatUdpV6 = new System.Windows.Forms.Label();
            this.lblStatUdpV4 = new System.Windows.Forms.Label();
            this.lblStatTcpV6 = new System.Windows.Forms.Label();
            this.lblStatTcpV4 = new System.Windows.Forms.Label();
            this.lblStatTotalCapturedPackets = new System.Windows.Forms.Label();
            this.lblStatIpV6 = new System.Windows.Forms.Label();
            this.lblStatIpV4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.picApplyFilter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGoto = new System.Windows.Forms.Panel();
            this.picGoToPrevious = new System.Windows.Forms.PictureBox();
            this.picGoToNext = new System.Windows.Forms.PictureBox();
            this.pnltools = new System.Windows.Forms.Panel();
            this.picProgramSettings = new System.Windows.Forms.PictureBox();
            this.picStatistics = new System.Windows.Forms.PictureBox();
            this.pnlTraffic = new System.Windows.Forms.Panel();
            this.lblUdpTrafficGenerator = new System.Windows.Forms.Label();
            this.lblIcmpTrafficGenerator = new System.Windows.Forms.Label();
            this.picIcmpTrafficGenerator = new System.Windows.Forms.PictureBox();
            this.picUdpTrafficGenerator = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timStatistics = new System.Windows.Forms.Timer(this.components);
            this.mnuMain.SuspendLayout();
            this.tolMain.SuspendLayout();
            this.staMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_First)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Third)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Collapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCollapseAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpandAll)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApplyFilter)).BeginInit();
            this.pnlGoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoToPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoToNext)).BeginInit();
            this.pnltools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgramSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistics)).BeginInit();
            this.pnlTraffic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcmpTrafficGenerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUdpTrafficGenerator)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.mnuItemNe,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(809, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.mnuItem_Exit});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.networkToolStripMenuItem.Text = "Program";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // mnuItem_Exit
            // 
            this.mnuItem_Exit.Name = "mnuItem_Exit";
            this.mnuItem_Exit.Size = new System.Drawing.Size(116, 22);
            this.mnuItem_Exit.Text = "Exit";
            this.mnuItem_Exit.Click += new System.EventHandler(this.mnuItem_Exit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemGoToPreviousPacket,
            this.mnuItemGoToNextPacket,
            this.toolStripSeparator6,
            this.mnuItem_ShowToolbar,
            this.mnuItem_ShowStatusbar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuItemGoToPreviousPacket
            // 
            this.mnuItemGoToPreviousPacket.Name = "mnuItemGoToPreviousPacket";
            this.mnuItemGoToPreviousPacket.Size = new System.Drawing.Size(192, 22);
            this.mnuItemGoToPreviousPacket.Text = "Go To Previous Packet";
            this.mnuItemGoToPreviousPacket.Click += new System.EventHandler(this.mnuItemGoToPreviousPacket_Click);
            // 
            // mnuItemGoToNextPacket
            // 
            this.mnuItemGoToNextPacket.Name = "mnuItemGoToNextPacket";
            this.mnuItemGoToNextPacket.Size = new System.Drawing.Size(192, 22);
            this.mnuItemGoToNextPacket.Text = "Go To Next Packet";
            this.mnuItemGoToNextPacket.Click += new System.EventHandler(this.mnuItemGoToNextPacket_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(189, 6);
            // 
            // mnuItem_ShowToolbar
            // 
            this.mnuItem_ShowToolbar.Checked = true;
            this.mnuItem_ShowToolbar.CheckOnClick = true;
            this.mnuItem_ShowToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuItem_ShowToolbar.Name = "mnuItem_ShowToolbar";
            this.mnuItem_ShowToolbar.Size = new System.Drawing.Size(192, 22);
            this.mnuItem_ShowToolbar.Text = "Toolbar";
            this.mnuItem_ShowToolbar.Click += new System.EventHandler(this.mnuItem_ShowToolbar_Click);
            // 
            // mnuItem_ShowStatusbar
            // 
            this.mnuItem_ShowStatusbar.Checked = true;
            this.mnuItem_ShowStatusbar.CheckOnClick = true;
            this.mnuItem_ShowStatusbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuItem_ShowStatusbar.Name = "mnuItem_ShowStatusbar";
            this.mnuItem_ShowStatusbar.Size = new System.Drawing.Size(192, 22);
            this.mnuItem_ShowStatusbar.Text = "Statusbar";
            this.mnuItem_ShowStatusbar.Click += new System.EventHandler(this.mnuItem_ShowStatusbar_Click);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Options,
            this.mnuItem_StartCapture,
            this.mnuItem_StopCapture,
            this.toolStripSeparator7,
            this.mnuItem_ClearDataGridView});
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.captureToolStripMenuItem.Text = "Capture";
            // 
            // mnuItem_Options
            // 
            this.mnuItem_Options.Name = "mnuItem_Options";
            this.mnuItem_Options.Size = new System.Drawing.Size(143, 22);
            this.mnuItem_Options.Text = "Options";
            this.mnuItem_Options.Click += new System.EventHandler(this.mnuItem_CaptureOptions_Click);
            this.mnuItem_Options.EnabledChanged += new System.EventHandler(this.mnuItem_Options_EnabledChanged);
            // 
            // mnuItem_StartCapture
            // 
            this.mnuItem_StartCapture.Name = "mnuItem_StartCapture";
            this.mnuItem_StartCapture.Size = new System.Drawing.Size(143, 22);
            this.mnuItem_StartCapture.Text = "Start Capture";
            this.mnuItem_StartCapture.Click += new System.EventHandler(this.mnuItem_StartCapture_Click);
            this.mnuItem_StartCapture.EnabledChanged += new System.EventHandler(this.mnuItem_StartCapture_EnabledChanged);
            // 
            // mnuItem_StopCapture
            // 
            this.mnuItem_StopCapture.Enabled = false;
            this.mnuItem_StopCapture.Name = "mnuItem_StopCapture";
            this.mnuItem_StopCapture.Size = new System.Drawing.Size(143, 22);
            this.mnuItem_StopCapture.Text = "Stop Capture";
            this.mnuItem_StopCapture.Click += new System.EventHandler(this.mnuItem_StopCapture_Click);
            this.mnuItem_StopCapture.EnabledChanged += new System.EventHandler(this.mnuItem_StopCapture_EnabledChanged);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(140, 6);
            // 
            // mnuItem_ClearDataGridView
            // 
            this.mnuItem_ClearDataGridView.Name = "mnuItem_ClearDataGridView";
            this.mnuItem_ClearDataGridView.Size = new System.Drawing.Size(143, 22);
            this.mnuItem_ClearDataGridView.Text = "Clear History";
            this.mnuItem_ClearDataGridView.Click += new System.EventHandler(this.mnuItem_ClearDataGridView_Click);
            // 
            // mnuItemNe
            // 
            this.mnuItemNe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_NetworkInterfaces,
            this.statisticsToolStripMenuItem,
            this.toolStripSeparator8,
            this.mnuItem_UdpTrafficGenerator,
            this.mnuItem_IcmpTrafficGenerator});
            this.mnuItemNe.Name = "mnuItemNe";
            this.mnuItemNe.Size = new System.Drawing.Size(60, 20);
            this.mnuItemNe.Text = "Nework";
            // 
            // mnuItem_NetworkInterfaces
            // 
            this.mnuItem_NetworkInterfaces.Name = "mnuItem_NetworkInterfaces";
            this.mnuItem_NetworkInterfaces.Size = new System.Drawing.Size(191, 22);
            this.mnuItem_NetworkInterfaces.Text = "Interfaces";
            this.mnuItem_NetworkInterfaces.Click += new System.EventHandler(this.mnuItem_NetworkInterfaces_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuItem_UdpTrafficGenerator
            // 
            this.mnuItem_UdpTrafficGenerator.Name = "mnuItem_UdpTrafficGenerator";
            this.mnuItem_UdpTrafficGenerator.Size = new System.Drawing.Size(191, 22);
            this.mnuItem_UdpTrafficGenerator.Text = "UDP Traffic Generator";
            this.mnuItem_UdpTrafficGenerator.Click += new System.EventHandler(this.mnuItem_UdpTrafficGenerator_Click);
            // 
            // mnuItem_IcmpTrafficGenerator
            // 
            this.mnuItem_IcmpTrafficGenerator.Name = "mnuItem_IcmpTrafficGenerator";
            this.mnuItem_IcmpTrafficGenerator.Size = new System.Drawing.Size(191, 22);
            this.mnuItem_IcmpTrafficGenerator.Text = "ICMP Trafic Generator";
            this.mnuItem_IcmpTrafficGenerator.Click += new System.EventHandler(this.mnuItem_IcmpTrafficGenerator_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_About});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuItem_About
            // 
            this.mnuItem_About.Name = "mnuItem_About";
            this.mnuItem_About.Size = new System.Drawing.Size(116, 22);
            this.mnuItem_About.Text = "About...";
            this.mnuItem_About.Click += new System.EventHandler(this.btnFormAbout_Click);
            // 
            // tolMain
            // 
            this.tolMain.BackColor = System.Drawing.Color.White;
            this.tolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCaptureOptions,
            this.btnStartCapture,
            this.btnStopCapture,
            this.toolStripSeparator4,
            this.toolStripSeparator3,
            this.toolStripSeparator5,
            this.btnFormAbout,
            this.toolStripSeparator10});
            this.tolMain.Location = new System.Drawing.Point(0, 24);
            this.tolMain.Name = "tolMain";
            this.tolMain.Size = new System.Drawing.Size(809, 71);
            this.tolMain.TabIndex = 1;
            this.tolMain.Text = "toolStrip1";
            // 
            // btnCaptureOptions
            // 
            this.btnCaptureOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaptureOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCaptureOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCaptureOptions.Image")));
            this.btnCaptureOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCaptureOptions.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCaptureOptions.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnCaptureOptions.Name = "btnCaptureOptions";
            this.btnCaptureOptions.Size = new System.Drawing.Size(68, 68);
            this.btnCaptureOptions.ToolTipText = "Capture Options";
            this.btnCaptureOptions.Click += new System.EventHandler(this.mnuItem_CaptureOptions_Click);
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.AutoSize = false;
            this.btnStartCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStartCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnStartCapture.Image")));
            this.btnStartCapture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStartCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(60, 68);
            this.btnStartCapture.ToolTipText = "Start Capture";
            this.btnStartCapture.Click += new System.EventHandler(this.mnuItem_StartCapture_Click);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.AutoSize = false;
            this.btnStopCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStopCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStopCapture.Enabled = false;
            this.btnStopCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnStopCapture.Image")));
            this.btnStopCapture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStopCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(60, 68);
            this.btnStopCapture.Text = "toolStripButton4";
            this.btnStopCapture.ToolTipText = "Stop Capture";
            this.btnStopCapture.Click += new System.EventHandler(this.mnuItem_StopCapture_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 69);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 69);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 65);
            this.toolStripSeparator5.Visible = false;
            // 
            // btnFormAbout
            // 
            this.btnFormAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFormAbout.AutoSize = false;
            this.btnFormAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFormAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFormAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnFormAbout.Image")));
            this.btnFormAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFormAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFormAbout.Name = "btnFormAbout";
            this.btnFormAbout.Size = new System.Drawing.Size(68, 68);
            this.btnFormAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFormAbout.ToolTipText = "About...";
            this.btnFormAbout.Click += new System.EventHandler(this.btnFormAbout_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(390, 0, 0, 0);
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 71);
            this.toolStripSeparator10.Visible = false;
            // 
            // staMain
            // 
            this.staMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.staMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblProgramStatus,
            this.lblElpsTime,
            this.lblElapsedTime});
            this.staMain.Location = new System.Drawing.Point(0, 431);
            this.staMain.Name = "staMain";
            this.staMain.Size = new System.Drawing.Size(809, 22);
            this.staMain.TabIndex = 2;
            this.staMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // lblProgramStatus
            // 
            this.lblProgramStatus.AutoSize = false;
            this.lblProgramStatus.ForeColor = System.Drawing.Color.Green;
            this.lblProgramStatus.LinkColor = System.Drawing.Color.Black;
            this.lblProgramStatus.Name = "lblProgramStatus";
            this.lblProgramStatus.Size = new System.Drawing.Size(90, 17);
            this.lblProgramStatus.Text = "Ready";
            this.lblProgramStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblElpsTime
            // 
            this.lblElpsTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblElpsTime.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.lblElpsTime.Name = "lblElpsTime";
            this.lblElpsTime.Size = new System.Drawing.Size(80, 17);
            this.lblElpsTime.Text = "Elapsed Time:";
            this.lblElpsTime.Visible = false;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.ForeColor = System.Drawing.Color.Blue;
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(49, 17);
            this.lblElapsedTime.Text = "00:00:00";
            this.lblElapsedTime.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 95);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(809, 336);
            this.splitContainer1.SplitterDistance = 559;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlTip);
            this.panel1.Controls.Add(this.dgvPackets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 336);
            this.panel1.TabIndex = 0;
            // 
            // pnlTip
            // 
            this.pnlTip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTip.Controls.Add(this.lnkInterfaceFound);
            this.pnlTip.Controls.Add(this.lblNumberOfInterfaces);
            this.pnlTip.Controls.Add(this.label20);
            this.pnlTip.Controls.Add(this.label19);
            this.pnlTip.Controls.Add(this.label18);
            this.pnlTip.Controls.Add(this.label17);
            this.pnlTip.Controls.Add(this.label16);
            this.pnlTip.Controls.Add(this.label15);
            this.pnlTip.Controls.Add(this.label14);
            this.pnlTip.Location = new System.Drawing.Point(11, 35);
            this.pnlTip.Name = "pnlTip";
            this.pnlTip.Size = new System.Drawing.Size(489, 270);
            this.pnlTip.TabIndex = 2;
            // 
            // lnkInterfaceFound
            // 
            this.lnkInterfaceFound.AutoSize = true;
            this.lnkInterfaceFound.Location = new System.Drawing.Point(35, 246);
            this.lnkInterfaceFound.Name = "lnkInterfaceFound";
            this.lnkInterfaceFound.Size = new System.Drawing.Size(212, 13);
            this.lnkInterfaceFound.TabIndex = 1;
            this.lnkInterfaceFound.TabStop = true;
            this.lnkInterfaceFound.Text = "Network interface(s) found in this computer.";
            this.lnkInterfaceFound.Click += new System.EventHandler(this.mnuItem_NetworkInterfaces_Click);
            // 
            // lblNumberOfInterfaces
            // 
            this.lblNumberOfInterfaces.AutoSize = true;
            this.lblNumberOfInterfaces.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumberOfInterfaces.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfInterfaces.Location = new System.Drawing.Point(15, 246);
            this.lblNumberOfInterfaces.Name = "lblNumberOfInterfaces";
            this.lblNumberOfInterfaces.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfInterfaces.TabIndex = 0;
            this.lblNumberOfInterfaces.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(35, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(274, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "6. To stop capturing packets click \'Stop\' button.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(35, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(385, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "5. Click \'Start Capture\' button to whiteNet starts capturing packets.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(35, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(241, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "4. Click \'Ok\' button and close the window.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(35, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "3. Set capture options.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(35, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(348, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "2. Choose network interface that you want capture it\'s taffic.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(35, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "1. Open \'Capture Options\' window.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(14, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(226, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "To capture incoming/outgoing packets:";
            // 
            // dgvPackets
            // 
            this.dgvPackets.AllowUserToAddRows = false;
            this.dgvPackets.AllowUserToDeleteRows = false;
            this.dgvPackets.AllowUserToOrderColumns = true;
            this.dgvPackets.AllowUserToResizeRows = false;
            this.dgvPackets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackets.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPackets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPackets.CausesValidation = false;
            this.dgvPackets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPackets.ColumnHeadersHeight = 25;
            this.dgvPackets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPackets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_NO,
            this.Col_Time,
            this.Col_Source,
            this.Col_Destination,
            this.Col_Protocol,
            this.Col_Length});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackets.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackets.Location = new System.Drawing.Point(0, 0);
            this.dgvPackets.MultiSelect = false;
            this.dgvPackets.Name = "dgvPackets";
            this.dgvPackets.ReadOnly = true;
            this.dgvPackets.RowHeadersVisible = false;
            this.dgvPackets.RowTemplate.Height = 19;
            this.dgvPackets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPackets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackets.Size = new System.Drawing.Size(557, 334);
            this.dgvPackets.TabIndex = 1;
            this.dgvPackets.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackets_RowEnter);
            // 
            // Col_NO
            // 
            this.Col_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_NO.FillWeight = 177.6649F;
            this.Col_NO.HeaderText = "No.";
            this.Col_NO.Name = "Col_NO";
            this.Col_NO.ReadOnly = true;
            this.Col_NO.ToolTipText = "Number of Packet";
            this.Col_NO.Width = 49;
            // 
            // Col_Time
            // 
            this.Col_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Time.HeaderText = "Time";
            this.Col_Time.Name = "Col_Time";
            this.Col_Time.ReadOnly = true;
            this.Col_Time.ToolTipText = "Time interval (Minute:Second::Millisecond)";
            this.Col_Time.Width = 69;
            // 
            // Col_Source
            // 
            this.Col_Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Source.FillWeight = 80.58376F;
            this.Col_Source.HeaderText = "Source";
            this.Col_Source.Name = "Col_Source";
            this.Col_Source.ReadOnly = true;
            this.Col_Source.ToolTipText = "Source Address";
            this.Col_Source.Width = 115;
            // 
            // Col_Destination
            // 
            this.Col_Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Destination.FillWeight = 80.58376F;
            this.Col_Destination.HeaderText = "Destination";
            this.Col_Destination.Name = "Col_Destination";
            this.Col_Destination.ReadOnly = true;
            this.Col_Destination.ToolTipText = "Destination Address";
            this.Col_Destination.Width = 107;
            // 
            // Col_Protocol
            // 
            this.Col_Protocol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Protocol.FillWeight = 80.58376F;
            this.Col_Protocol.HeaderText = "Protocol";
            this.Col_Protocol.Name = "Col_Protocol";
            this.Col_Protocol.ReadOnly = true;
            this.Col_Protocol.ToolTipText = "Protocol";
            this.Col_Protocol.Width = 80;
            // 
            // Col_Length
            // 
            this.Col_Length.FillWeight = 80.58376F;
            this.Col_Length.HeaderText = "Length";
            this.Col_Length.Name = "Col_Length";
            this.Col_Length.ReadOnly = true;
            this.Col_Length.ToolTipText = "Length of Packet (Bytes)";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel6);
            this.splitContainer2.Size = new System.Drawing.Size(246, 336);
            this.splitContainer2.SplitterDistance = 163;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.picDefault_First);
            this.panel2.Controls.Add(this.picDefault_Third);
            this.panel2.Controls.Add(this.picDefault_Second);
            this.panel2.Controls.Add(this.picDefault_Expand);
            this.panel2.Controls.Add(this.picDefault_Collapse);
            this.panel2.Controls.Add(this.picCollapseAll);
            this.panel2.Controls.Add(this.picExpandAll);
            this.panel2.Controls.Add(this.trePacket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 163);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(61, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 20);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // picDefault_First
            // 
            this.picDefault_First.BackColor = System.Drawing.Color.Transparent;
            this.picDefault_First.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDefault_First.Image = ((System.Drawing.Image)(resources.GetObject("picDefault_First.Image")));
            this.picDefault_First.Location = new System.Drawing.Point(132, 2);
            this.picDefault_First.Name = "picDefault_First";
            this.picDefault_First.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.picDefault_First.Size = new System.Drawing.Size(20, 20);
            this.picDefault_First.TabIndex = 2;
            this.picDefault_First.TabStop = false;
            this.toolTip1.SetToolTip(this.picDefault_First, "Default nodes mode: Expand First Node");
            this.picDefault_First.Click += new System.EventHandler(this.picDefaultNodesState_Click);
            // 
            // picDefault_Third
            // 
            this.picDefault_Third.BackColor = System.Drawing.Color.Transparent;
            this.picDefault_Third.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDefault_Third.Image = ((System.Drawing.Image)(resources.GetObject("picDefault_Third.Image")));
            this.picDefault_Third.Location = new System.Drawing.Point(184, 2);
            this.picDefault_Third.Name = "picDefault_Third";
            this.picDefault_Third.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.picDefault_Third.Size = new System.Drawing.Size(20, 20);
            this.picDefault_Third.TabIndex = 2;
            this.picDefault_Third.TabStop = false;
            this.toolTip1.SetToolTip(this.picDefault_Third, "Default nodes mode: Expand Third Node");
            this.picDefault_Third.Click += new System.EventHandler(this.picDefaultNodesState_Click);
            // 
            // picDefault_Second
            // 
            this.picDefault_Second.BackColor = System.Drawing.Color.Transparent;
            this.picDefault_Second.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDefault_Second.Image = ((System.Drawing.Image)(resources.GetObject("picDefault_Second.Image")));
            this.picDefault_Second.Location = new System.Drawing.Point(158, 2);
            this.picDefault_Second.Name = "picDefault_Second";
            this.picDefault_Second.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.picDefault_Second.Size = new System.Drawing.Size(20, 20);
            this.picDefault_Second.TabIndex = 2;
            this.picDefault_Second.TabStop = false;
            this.toolTip1.SetToolTip(this.picDefault_Second, "Default nodes mode: Expand Second Node");
            this.picDefault_Second.Click += new System.EventHandler(this.picDefaultNodesState_Click);
            // 
            // picDefault_Expand
            // 
            this.picDefault_Expand.BackColor = System.Drawing.Color.Gainsboro;
            this.picDefault_Expand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDefault_Expand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDefault_Expand.Image = ((System.Drawing.Image)(resources.GetObject("picDefault_Expand.Image")));
            this.picDefault_Expand.Location = new System.Drawing.Point(106, 2);
            this.picDefault_Expand.Name = "picDefault_Expand";
            this.picDefault_Expand.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.picDefault_Expand.Size = new System.Drawing.Size(20, 20);
            this.picDefault_Expand.TabIndex = 2;
            this.picDefault_Expand.TabStop = false;
            this.toolTip1.SetToolTip(this.picDefault_Expand, "Default nodes mode: Expand All Nodes");
            this.picDefault_Expand.Click += new System.EventHandler(this.picDefaultNodesState_Click);
            // 
            // picDefault_Collapse
            // 
            this.picDefault_Collapse.BackColor = System.Drawing.Color.Transparent;
            this.picDefault_Collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDefault_Collapse.Image = ((System.Drawing.Image)(resources.GetObject("picDefault_Collapse.Image")));
            this.picDefault_Collapse.Location = new System.Drawing.Point(80, 2);
            this.picDefault_Collapse.Name = "picDefault_Collapse";
            this.picDefault_Collapse.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.picDefault_Collapse.Size = new System.Drawing.Size(20, 20);
            this.picDefault_Collapse.TabIndex = 2;
            this.picDefault_Collapse.TabStop = false;
            this.toolTip1.SetToolTip(this.picDefault_Collapse, "Default nodes mode: Collapse All Nodes");
            this.picDefault_Collapse.Click += new System.EventHandler(this.picDefaultNodesState_Click);
            // 
            // picCollapseAll
            // 
            this.picCollapseAll.BackColor = System.Drawing.Color.Transparent;
            this.picCollapseAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("picCollapseAll.Image")));
            this.picCollapseAll.Location = new System.Drawing.Point(30, 4);
            this.picCollapseAll.Name = "picCollapseAll";
            this.picCollapseAll.Size = new System.Drawing.Size(16, 16);
            this.picCollapseAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCollapseAll.TabIndex = 2;
            this.picCollapseAll.TabStop = false;
            this.toolTip1.SetToolTip(this.picCollapseAll, "Collapse All Nodes");
            this.picCollapseAll.Click += new System.EventHandler(this.picCollapseAll_Click);
            this.picCollapseAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCollapseAll_MouseDown);
            this.picCollapseAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCollapseAll_MouseUp);
            // 
            // picExpandAll
            // 
            this.picExpandAll.BackColor = System.Drawing.Color.Transparent;
            this.picExpandAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("picExpandAll.Image")));
            this.picExpandAll.Location = new System.Drawing.Point(8, 4);
            this.picExpandAll.Name = "picExpandAll";
            this.picExpandAll.Size = new System.Drawing.Size(16, 16);
            this.picExpandAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExpandAll.TabIndex = 2;
            this.picExpandAll.TabStop = false;
            this.toolTip1.SetToolTip(this.picExpandAll, "Expand All Nodes");
            this.picExpandAll.Click += new System.EventHandler(this.picExpandAll_Click);
            this.picExpandAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picExpandAll_MouseDown);
            this.picExpandAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picExpandAll_MouseUp);
            // 
            // trePacket
            // 
            this.trePacket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trePacket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trePacket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trePacket.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trePacket.Location = new System.Drawing.Point(-1, 24);
            this.trePacket.Name = "trePacket";
            this.trePacket.Size = new System.Drawing.Size(246, 138);
            this.trePacket.TabIndex = 1;
            this.trePacket.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trePacket_AfterSelect);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 169);
            this.panel6.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 162);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.lblStatArp);
            this.panel7.Controls.Add(this.lblStatGreV4);
            this.panel7.Controls.Add(this.lblStatIgmpV4);
            this.panel7.Controls.Add(this.lblStatIcmpV6);
            this.panel7.Controls.Add(this.lblStatIcmpV4);
            this.panel7.Controls.Add(this.lblStatUdpV6);
            this.panel7.Controls.Add(this.lblStatUdpV4);
            this.panel7.Controls.Add(this.lblStatTcpV6);
            this.panel7.Controls.Add(this.lblStatTcpV4);
            this.panel7.Controls.Add(this.lblStatTotalCapturedPackets);
            this.panel7.Controls.Add(this.lblStatIpV6);
            this.panel7.Controls.Add(this.lblStatIpV4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(232, 143);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(118, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "UDP v6:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(11, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "UDP v4:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(118, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "ICMP v6:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(11, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "ICMP v4:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(118, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "TCP v6:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(11, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TCP v4:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(11, 103);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "IGMP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(118, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ARP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(11, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "GRE v4:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(118, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "IPv6:";
            // 
            // lblStatArp
            // 
            this.lblStatArp.AutoSize = true;
            this.lblStatArp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatArp.Location = new System.Drawing.Point(170, 103);
            this.lblStatArp.Name = "lblStatArp";
            this.lblStatArp.Size = new System.Drawing.Size(13, 13);
            this.lblStatArp.TabIndex = 1;
            this.lblStatArp.Text = "0";
            // 
            // lblStatGreV4
            // 
            this.lblStatGreV4.AutoSize = true;
            this.lblStatGreV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatGreV4.Location = new System.Drawing.Point(62, 120);
            this.lblStatGreV4.Name = "lblStatGreV4";
            this.lblStatGreV4.Size = new System.Drawing.Size(13, 13);
            this.lblStatGreV4.TabIndex = 1;
            this.lblStatGreV4.Text = "0";
            // 
            // lblStatIgmpV4
            // 
            this.lblStatIgmpV4.AutoSize = true;
            this.lblStatIgmpV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatIgmpV4.Location = new System.Drawing.Point(62, 103);
            this.lblStatIgmpV4.Name = "lblStatIgmpV4";
            this.lblStatIgmpV4.Size = new System.Drawing.Size(13, 13);
            this.lblStatIgmpV4.TabIndex = 1;
            this.lblStatIgmpV4.Text = "0";
            // 
            // lblStatIcmpV6
            // 
            this.lblStatIcmpV6.AutoSize = true;
            this.lblStatIcmpV6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatIcmpV6.Location = new System.Drawing.Point(170, 86);
            this.lblStatIcmpV6.Name = "lblStatIcmpV6";
            this.lblStatIcmpV6.Size = new System.Drawing.Size(13, 13);
            this.lblStatIcmpV6.TabIndex = 1;
            this.lblStatIcmpV6.Text = "0";
            // 
            // lblStatIcmpV4
            // 
            this.lblStatIcmpV4.AutoSize = true;
            this.lblStatIcmpV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatIcmpV4.Location = new System.Drawing.Point(62, 86);
            this.lblStatIcmpV4.Name = "lblStatIcmpV4";
            this.lblStatIcmpV4.Size = new System.Drawing.Size(13, 13);
            this.lblStatIcmpV4.TabIndex = 1;
            this.lblStatIcmpV4.Text = "0";
            // 
            // lblStatUdpV6
            // 
            this.lblStatUdpV6.AutoSize = true;
            this.lblStatUdpV6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatUdpV6.Location = new System.Drawing.Point(170, 69);
            this.lblStatUdpV6.Name = "lblStatUdpV6";
            this.lblStatUdpV6.Size = new System.Drawing.Size(13, 13);
            this.lblStatUdpV6.TabIndex = 1;
            this.lblStatUdpV6.Text = "0";
            // 
            // lblStatUdpV4
            // 
            this.lblStatUdpV4.AutoSize = true;
            this.lblStatUdpV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatUdpV4.Location = new System.Drawing.Point(62, 69);
            this.lblStatUdpV4.Name = "lblStatUdpV4";
            this.lblStatUdpV4.Size = new System.Drawing.Size(13, 13);
            this.lblStatUdpV4.TabIndex = 1;
            this.lblStatUdpV4.Text = "0";
            // 
            // lblStatTcpV6
            // 
            this.lblStatTcpV6.AutoSize = true;
            this.lblStatTcpV6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatTcpV6.Location = new System.Drawing.Point(170, 52);
            this.lblStatTcpV6.Name = "lblStatTcpV6";
            this.lblStatTcpV6.Size = new System.Drawing.Size(13, 13);
            this.lblStatTcpV6.TabIndex = 1;
            this.lblStatTcpV6.Text = "0";
            // 
            // lblStatTcpV4
            // 
            this.lblStatTcpV4.AutoSize = true;
            this.lblStatTcpV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatTcpV4.Location = new System.Drawing.Point(62, 52);
            this.lblStatTcpV4.Name = "lblStatTcpV4";
            this.lblStatTcpV4.Size = new System.Drawing.Size(13, 13);
            this.lblStatTcpV4.TabIndex = 1;
            this.lblStatTcpV4.Text = "0";
            // 
            // lblStatTotalCapturedPackets
            // 
            this.lblStatTotalCapturedPackets.AutoSize = true;
            this.lblStatTotalCapturedPackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStatTotalCapturedPackets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatTotalCapturedPackets.Location = new System.Drawing.Point(127, 1);
            this.lblStatTotalCapturedPackets.Name = "lblStatTotalCapturedPackets";
            this.lblStatTotalCapturedPackets.Size = new System.Drawing.Size(14, 13);
            this.lblStatTotalCapturedPackets.TabIndex = 1;
            this.lblStatTotalCapturedPackets.Text = "0";
            // 
            // lblStatIpV6
            // 
            this.lblStatIpV6.AutoSize = true;
            this.lblStatIpV6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatIpV6.Location = new System.Drawing.Point(170, 35);
            this.lblStatIpV6.Name = "lblStatIpV6";
            this.lblStatIpV6.Size = new System.Drawing.Size(13, 13);
            this.lblStatIpV6.TabIndex = 1;
            this.lblStatIpV6.Text = "0";
            // 
            // lblStatIpV4
            // 
            this.lblStatIpV4.AutoSize = true;
            this.lblStatIpV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatIpV4.Location = new System.Drawing.Point(62, 35);
            this.lblStatIpV4.Name = "lblStatIpV4";
            this.lblStatIpV4.Size = new System.Drawing.Size(13, 13);
            this.lblStatIpV4.TabIndex = 1;
            this.lblStatIpV4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "IPv4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Packets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Captured Packets:";
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.BackColor = System.Drawing.Color.White;
            this.grpFilter.Controls.Add(this.cmbFilter);
            this.grpFilter.Controls.Add(this.picApplyFilter);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.ForeColor = System.Drawing.Color.Silver;
            this.grpFilter.Location = new System.Drawing.Point(404, 30);
            this.grpFilter.MinimumSize = new System.Drawing.Size(131, 30);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(272, 55);
            this.grpFilter.TabIndex = 4;
            this.grpFilter.TabStop = false;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "ip",
            "icmp",
            "tcp",
            "udp"});
            this.cmbFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbFilter.BackColor = System.Drawing.Color.White;
            this.cmbFilter.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "None",
            "IP",
            "IPX",
            "ICMP",
            "ARP",
            "TCP",
            "UDP",
            "eth.addr==FF:FF:FF:FF:FF:FF",
            "not ARP",
            "IP.addr==192.168.0.1",
            "IP.addr==255.255.255.255",
            "!(IP.addr== 92.168.0.1)",
            "TCP.port==80",
            "TCP.port==25",
            "TCP.port==23",
            "UDP.port== 80",
            "TCP.port==80 || udp.port==80",
            "UDP.port==53"});
            this.cmbFilter.Location = new System.Drawing.Point(40, 20);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(184, 22);
            this.cmbFilter.TabIndex = 1;
            // 
            // picApplyFilter
            // 
            this.picApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picApplyFilter.BackColor = System.Drawing.Color.White;
            this.picApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picApplyFilter.Image = ((System.Drawing.Image)(resources.GetObject("picApplyFilter.Image")));
            this.picApplyFilter.Location = new System.Drawing.Point(230, 17);
            this.picApplyFilter.Name = "picApplyFilter";
            this.picApplyFilter.Size = new System.Drawing.Size(30, 25);
            this.picApplyFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picApplyFilter.TabIndex = 0;
            this.picApplyFilter.TabStop = false;
            this.toolTip1.SetToolTip(this.picApplyFilter, "Apply");
            this.picApplyFilter.Click += new System.EventHandler(this.picApplyFilter_Click);
            this.picApplyFilter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picApplyFilter_MouseDown);
            this.picApplyFilter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picApplyFilter_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter:";
            // 
            // pnlGoto
            // 
            this.pnlGoto.BackColor = System.Drawing.Color.White;
            this.pnlGoto.Controls.Add(this.picGoToPrevious);
            this.pnlGoto.Controls.Add(this.picGoToNext);
            this.pnlGoto.Location = new System.Drawing.Point(214, 29);
            this.pnlGoto.Name = "pnlGoto";
            this.pnlGoto.Size = new System.Drawing.Size(38, 63);
            this.pnlGoto.TabIndex = 5;
            // 
            // picGoToPrevious
            // 
            this.picGoToPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGoToPrevious.BackColor = System.Drawing.Color.White;
            this.picGoToPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGoToPrevious.Image = ((System.Drawing.Image)(resources.GetObject("picGoToPrevious.Image")));
            this.picGoToPrevious.Location = new System.Drawing.Point(0, 1);
            this.picGoToPrevious.Name = "picGoToPrevious";
            this.picGoToPrevious.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.picGoToPrevious.Size = new System.Drawing.Size(33, 28);
            this.picGoToPrevious.TabIndex = 0;
            this.picGoToPrevious.TabStop = false;
            this.toolTip1.SetToolTip(this.picGoToPrevious, "Go to previous packet");
            this.picGoToPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGoToPrevious_MouseDown);
            this.picGoToPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picGoToPrevious_MouseUp);
            // 
            // picGoToNext
            // 
            this.picGoToNext.BackColor = System.Drawing.Color.White;
            this.picGoToNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGoToNext.Image = ((System.Drawing.Image)(resources.GetObject("picGoToNext.Image")));
            this.picGoToNext.Location = new System.Drawing.Point(0, 32);
            this.picGoToNext.Name = "picGoToNext";
            this.picGoToNext.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.picGoToNext.Size = new System.Drawing.Size(33, 28);
            this.picGoToNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGoToNext.TabIndex = 0;
            this.picGoToNext.TabStop = false;
            this.toolTip1.SetToolTip(this.picGoToNext, "Go to next packet");
            this.picGoToNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGoToNext_MouseDown);
            this.picGoToNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picGoToNext_MouseUp);
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.White;
            this.pnltools.Controls.Add(this.picProgramSettings);
            this.pnltools.Controls.Add(this.picStatistics);
            this.pnltools.Location = new System.Drawing.Point(263, 29);
            this.pnltools.Name = "pnltools";
            this.pnltools.Size = new System.Drawing.Size(36, 63);
            this.pnltools.TabIndex = 6;
            // 
            // picProgramSettings
            // 
            this.picProgramSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProgramSettings.BackColor = System.Drawing.Color.White;
            this.picProgramSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProgramSettings.Enabled = false;
            this.picProgramSettings.Image = ((System.Drawing.Image)(resources.GetObject("picProgramSettings.Image")));
            this.picProgramSettings.Location = new System.Drawing.Point(0, 32);
            this.picProgramSettings.Name = "picProgramSettings";
            this.picProgramSettings.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.picProgramSettings.Size = new System.Drawing.Size(36, 28);
            this.picProgramSettings.TabIndex = 0;
            this.picProgramSettings.TabStop = false;
            this.toolTip1.SetToolTip(this.picProgramSettings, "Settings");
            // 
            // picStatistics
            // 
            this.picStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picStatistics.BackColor = System.Drawing.Color.White;
            this.picStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStatistics.Image = ((System.Drawing.Image)(resources.GetObject("picStatistics.Image")));
            this.picStatistics.Location = new System.Drawing.Point(0, 0);
            this.picStatistics.Name = "picStatistics";
            this.picStatistics.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.picStatistics.Size = new System.Drawing.Size(36, 28);
            this.picStatistics.TabIndex = 0;
            this.picStatistics.TabStop = false;
            this.toolTip1.SetToolTip(this.picStatistics, "Network Statistics");
            // 
            // pnlTraffic
            // 
            this.pnlTraffic.BackColor = System.Drawing.Color.White;
            this.pnlTraffic.Controls.Add(this.lblUdpTrafficGenerator);
            this.pnlTraffic.Controls.Add(this.lblIcmpTrafficGenerator);
            this.pnlTraffic.Controls.Add(this.picIcmpTrafficGenerator);
            this.pnlTraffic.Controls.Add(this.picUdpTrafficGenerator);
            this.pnlTraffic.Location = new System.Drawing.Point(313, 30);
            this.pnlTraffic.Name = "pnlTraffic";
            this.pnlTraffic.Size = new System.Drawing.Size(72, 62);
            this.pnlTraffic.TabIndex = 7;
            // 
            // lblUdpTrafficGenerator
            // 
            this.lblUdpTrafficGenerator.BackColor = System.Drawing.Color.White;
            this.lblUdpTrafficGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUdpTrafficGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUdpTrafficGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblUdpTrafficGenerator.Location = new System.Drawing.Point(29, 14);
            this.lblUdpTrafficGenerator.Margin = new System.Windows.Forms.Padding(0);
            this.lblUdpTrafficGenerator.Name = "lblUdpTrafficGenerator";
            this.lblUdpTrafficGenerator.Size = new System.Drawing.Size(33, 13);
            this.lblUdpTrafficGenerator.TabIndex = 1;
            this.lblUdpTrafficGenerator.Text = "UDP";
            this.toolTip1.SetToolTip(this.lblUdpTrafficGenerator, "UDP Traffic Generator");
            this.lblUdpTrafficGenerator.Click += new System.EventHandler(this.mnuItem_UdpTrafficGenerator_Click);
            this.lblUdpTrafficGenerator.MouseEnter += new System.EventHandler(this.picUdpTrafficGenerator_MouseEnter);
            this.lblUdpTrafficGenerator.MouseLeave += new System.EventHandler(this.picUdpTrafficGenerator_MouseLeave);
            // 
            // lblIcmpTrafficGenerator
            // 
            this.lblIcmpTrafficGenerator.AutoSize = true;
            this.lblIcmpTrafficGenerator.BackColor = System.Drawing.Color.White;
            this.lblIcmpTrafficGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIcmpTrafficGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIcmpTrafficGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblIcmpTrafficGenerator.Location = new System.Drawing.Point(29, 44);
            this.lblIcmpTrafficGenerator.Name = "lblIcmpTrafficGenerator";
            this.lblIcmpTrafficGenerator.Size = new System.Drawing.Size(37, 13);
            this.lblIcmpTrafficGenerator.TabIndex = 1;
            this.lblIcmpTrafficGenerator.Text = "ICMP";
            this.toolTip1.SetToolTip(this.lblIcmpTrafficGenerator, "ICMP Traffic Generator");
            this.lblIcmpTrafficGenerator.Click += new System.EventHandler(this.mnuItem_IcmpTrafficGenerator_Click);
            this.lblIcmpTrafficGenerator.MouseEnter += new System.EventHandler(this.picIcmpTrafficGenerator_MouseEnter);
            this.lblIcmpTrafficGenerator.MouseLeave += new System.EventHandler(this.picIcmpTrafficGenerator_MouseLeave);
            // 
            // picIcmpTrafficGenerator
            // 
            this.picIcmpTrafficGenerator.BackColor = System.Drawing.Color.White;
            this.picIcmpTrafficGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIcmpTrafficGenerator.Image = ((System.Drawing.Image)(resources.GetObject("picIcmpTrafficGenerator.Image")));
            this.picIcmpTrafficGenerator.Location = new System.Drawing.Point(3, 30);
            this.picIcmpTrafficGenerator.Name = "picIcmpTrafficGenerator";
            this.picIcmpTrafficGenerator.Size = new System.Drawing.Size(69, 28);
            this.picIcmpTrafficGenerator.TabIndex = 0;
            this.picIcmpTrafficGenerator.TabStop = false;
            this.toolTip1.SetToolTip(this.picIcmpTrafficGenerator, "ICMP Traffic Generator");
            this.picIcmpTrafficGenerator.Click += new System.EventHandler(this.mnuItem_IcmpTrafficGenerator_Click);
            this.picIcmpTrafficGenerator.MouseEnter += new System.EventHandler(this.picIcmpTrafficGenerator_MouseEnter);
            this.picIcmpTrafficGenerator.MouseLeave += new System.EventHandler(this.picIcmpTrafficGenerator_MouseLeave);
            // 
            // picUdpTrafficGenerator
            // 
            this.picUdpTrafficGenerator.BackColor = System.Drawing.Color.White;
            this.picUdpTrafficGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUdpTrafficGenerator.Image = ((System.Drawing.Image)(resources.GetObject("picUdpTrafficGenerator.Image")));
            this.picUdpTrafficGenerator.Location = new System.Drawing.Point(3, 0);
            this.picUdpTrafficGenerator.Name = "picUdpTrafficGenerator";
            this.picUdpTrafficGenerator.Size = new System.Drawing.Size(68, 28);
            this.picUdpTrafficGenerator.TabIndex = 0;
            this.picUdpTrafficGenerator.TabStop = false;
            this.toolTip1.SetToolTip(this.picUdpTrafficGenerator, "UDP Traffic Generator");
            this.picUdpTrafficGenerator.Click += new System.EventHandler(this.mnuItem_UdpTrafficGenerator_Click);
            this.picUdpTrafficGenerator.MouseEnter += new System.EventHandler(this.picUdpTrafficGenerator_MouseEnter);
            this.picUdpTrafficGenerator.MouseLeave += new System.EventHandler(this.picUdpTrafficGenerator_MouseLeave);
            // 
            // timStatistics
            // 
            this.timStatistics.Interval = 500;
            this.timStatistics.Tick += new System.EventHandler(this.timStatistics_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 453);
            this.Controls.Add(this.pnlTraffic);
            this.Controls.Add(this.pnltools);
            this.Controls.Add(this.pnlGoto);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.staMain);
            this.Controls.Add(this.tolMain);
            this.Controls.Add(this.mnuMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(674, 220);
            this.Name = "FormMain";
            this.Text = "WhiteNet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tolMain.ResumeLayout(false);
            this.tolMain.PerformLayout();
            this.staMain.ResumeLayout(false);
            this.staMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTip.ResumeLayout(false);
            this.pnlTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackets)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_First)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Third)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault_Collapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCollapseAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpandAll)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApplyFilter)).EndInit();
            this.pnlGoto.ResumeLayout(false);
            this.pnlGoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoToPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoToNext)).EndInit();
            this.pnltools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProgramSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistics)).EndInit();
            this.pnlTraffic.ResumeLayout(false);
            this.pnlTraffic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcmpTrafficGenerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUdpTrafficGenerator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStrip tolMain;
        private System.Windows.Forms.StatusStrip staMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemNe;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_NetworkInterfaces;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Options;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_StopCapture;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_StartCapture;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_ClearDataGridView;
        private System.Windows.Forms.ToolStripButton btnCaptureOptions;
        private System.Windows.Forms.ToolStripButton btnStartCapture;
        private System.Windows.Forms.ToolStripButton btnStopCapture;
        private System.Windows.Forms.ToolStripButton btnFormAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPackets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView trePacket;
        private System.Windows.Forms.PictureBox picExpandAll;
        private System.Windows.Forms.PictureBox picCollapseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_UdpTrafficGenerator;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_IcmpTrafficGenerator;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_ShowToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_ShowStatusbar;
        private System.Windows.Forms.Panel pnlGoto;
        private System.Windows.Forms.PictureBox picGoToPrevious;
        private System.Windows.Forms.PictureBox picGoToNext;
        private System.Windows.Forms.Panel pnltools;
        private System.Windows.Forms.PictureBox picProgramSettings;
        private System.Windows.Forms.PictureBox picStatistics;
        private System.Windows.Forms.Panel pnlTraffic;
        private System.Windows.Forms.PictureBox picIcmpTrafficGenerator;
        private System.Windows.Forms.PictureBox picUdpTrafficGenerator;
        private System.Windows.Forms.Label lblUdpTrafficGenerator;
        private System.Windows.Forms.Label lblIcmpTrafficGenerator;
        private System.Windows.Forms.PictureBox picApplyFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picDefault_Collapse;
        private System.Windows.Forms.PictureBox picDefault_Expand;
        private System.Windows.Forms.PictureBox picDefault_First;
        private System.Windows.Forms.PictureBox picDefault_Second;
        private System.Windows.Forms.PictureBox picDefault_Third;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGoToPreviousPacket;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGoToNextPacket;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblProgramStatus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlTip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblNumberOfInterfaces;
        private System.Windows.Forms.Timer timStatistics;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel lblElpsTime;
        private System.Windows.Forms.ToolStripStatusLabel lblElapsedTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatArp;
        private System.Windows.Forms.Label lblStatGreV4;
        private System.Windows.Forms.Label lblStatIgmpV4;
        private System.Windows.Forms.Label lblStatIcmpV6;
        private System.Windows.Forms.Label lblStatIcmpV4;
        private System.Windows.Forms.Label lblStatUdpV6;
        private System.Windows.Forms.Label lblStatUdpV4;
        private System.Windows.Forms.Label lblStatTcpV6;
        private System.Windows.Forms.Label lblStatTcpV4;
        private System.Windows.Forms.Label lblStatIpV6;
        private System.Windows.Forms.Label lblStatIpV4;
        private System.Windows.Forms.Label lblStatTotalCapturedPackets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Length;
        private System.Windows.Forms.LinkLabel lnkInterfaceFound;
    }
}

