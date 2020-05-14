namespace WhiteNet
{
    partial class FormIcmpTrafficGenerator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIcmpTrafficGenerator));
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.grpTerminationCriteria = new System.Windows.Forms.GroupBox();
            this.numExecuteDuration = new System.Windows.Forms.NumericUpDown();
            this.numDataUnitsToSend = new System.Windows.Forms.NumericUpDown();
            this.cmbTimeUnit = new System.Windows.Forms.ComboBox();
            this.cmbDataSizeUnit = new System.Windows.Forms.ComboBox();
            this.radTerminationCriteria_None = new System.Windows.Forms.RadioButton();
            this.radTerminationCriteria_Time = new System.Windows.Forms.RadioButton();
            this.radTerminationCriteria_Data = new System.Windows.Forms.RadioButton();
            this.lbl_Static1 = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.numIpTimeToLive = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.chkDontFragment = new System.Windows.Forms.CheckBox();
            this.numReplyTimeout = new System.Windows.Forms.NumericUpDown();
            this.numMaxErrors = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfConnections = new System.Windows.Forms.NumericUpDown();
            this.numPayloadSize = new System.Windows.Forms.NumericUpDown();
            this.cmbPayloadSizeUnit = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.lblAvrageRtt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRecivedData = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.lblTotalErrors = new System.Windows.Forms.Label();
            this.lblSentData = new System.Windows.Forms.Label();
            this.cmbSentDataUnit = new System.Windows.Forms.ComboBox();
            this.lblLossRate = new System.Windows.Forms.Label();
            this.lblLostPackets = new System.Windows.Forms.Label();
            this.lblTotalReplies = new System.Windows.Forms.Label();
            this.lblTotalSentPackets = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timStatistics = new System.Windows.Forms.Timer(this.components);
            this.Col_Connection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SentPackets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Replies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LossRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AvgRtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpDestination.SuspendLayout();
            this.grpTerminationCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExecuteDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataUnitsToSend)).BeginInit();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIpTimeToLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReplyTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayloadSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.grpStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.label1);
            this.grpDestination.Controls.Add(this.txtHost);
            this.grpDestination.Location = new System.Drawing.Point(12, 12);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(364, 54);
            this.grpDestination.TabIndex = 0;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(44, 19);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(312, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.Text = "tabrizu.ac.ir";
            this.toolTip1.SetToolTip(this.txtHost, "Host name or IP address");
            // 
            // grpTerminationCriteria
            // 
            this.grpTerminationCriteria.Controls.Add(this.numExecuteDuration);
            this.grpTerminationCriteria.Controls.Add(this.numDataUnitsToSend);
            this.grpTerminationCriteria.Controls.Add(this.cmbTimeUnit);
            this.grpTerminationCriteria.Controls.Add(this.cmbDataSizeUnit);
            this.grpTerminationCriteria.Controls.Add(this.radTerminationCriteria_None);
            this.grpTerminationCriteria.Controls.Add(this.radTerminationCriteria_Time);
            this.grpTerminationCriteria.Controls.Add(this.radTerminationCriteria_Data);
            this.grpTerminationCriteria.Controls.Add(this.lbl_Static1);
            this.grpTerminationCriteria.Location = new System.Drawing.Point(12, 72);
            this.grpTerminationCriteria.Name = "grpTerminationCriteria";
            this.grpTerminationCriteria.Size = new System.Drawing.Size(364, 102);
            this.grpTerminationCriteria.TabIndex = 1;
            this.grpTerminationCriteria.TabStop = false;
            this.grpTerminationCriteria.Text = "Termination Criteria";
            // 
            // numExecuteDuration
            // 
            this.numExecuteDuration.Enabled = false;
            this.numExecuteDuration.Location = new System.Drawing.Point(127, 45);
            this.numExecuteDuration.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numExecuteDuration.Name = "numExecuteDuration";
            this.numExecuteDuration.Size = new System.Drawing.Size(65, 20);
            this.numExecuteDuration.TabIndex = 4;
            this.numExecuteDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numDataUnitsToSend
            // 
            this.numDataUnitsToSend.Location = new System.Drawing.Point(127, 19);
            this.numDataUnitsToSend.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numDataUnitsToSend.Name = "numDataUnitsToSend";
            this.numDataUnitsToSend.Size = new System.Drawing.Size(65, 20);
            this.numDataUnitsToSend.TabIndex = 1;
            this.numDataUnitsToSend.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cmbTimeUnit
            // 
            this.cmbTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeUnit.Enabled = false;
            this.cmbTimeUnit.FormattingEnabled = true;
            this.cmbTimeUnit.Items.AddRange(new object[] {
            "Secends",
            "Minutes",
            "Hours"});
            this.cmbTimeUnit.Location = new System.Drawing.Point(198, 45);
            this.cmbTimeUnit.Name = "cmbTimeUnit";
            this.cmbTimeUnit.Size = new System.Drawing.Size(100, 21);
            this.cmbTimeUnit.TabIndex = 5;
            // 
            // cmbDataSizeUnit
            // 
            this.cmbDataSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataSizeUnit.FormattingEnabled = true;
            this.cmbDataSizeUnit.Items.AddRange(new object[] {
            "ICMP Packet",
            "Bytes",
            "Kilobytes",
            "Megabytes",
            "Gigabytes"});
            this.cmbDataSizeUnit.Location = new System.Drawing.Point(198, 19);
            this.cmbDataSizeUnit.Name = "cmbDataSizeUnit";
            this.cmbDataSizeUnit.Size = new System.Drawing.Size(100, 21);
            this.cmbDataSizeUnit.TabIndex = 2;
            // 
            // radTerminationCriteria_None
            // 
            this.radTerminationCriteria_None.AutoSize = true;
            this.radTerminationCriteria_None.Location = new System.Drawing.Point(9, 72);
            this.radTerminationCriteria_None.Name = "radTerminationCriteria_None";
            this.radTerminationCriteria_None.Size = new System.Drawing.Size(106, 17);
            this.radTerminationCriteria_None.TabIndex = 6;
            this.radTerminationCriteria_None.Text = "None (don\'t stop)";
            this.radTerminationCriteria_None.UseVisualStyleBackColor = true;
            this.radTerminationCriteria_None.CheckedChanged += new System.EventHandler(this.radTerminationcriteria_CheckedChanged);
            // 
            // radTerminationCriteria_Time
            // 
            this.radTerminationCriteria_Time.AutoSize = true;
            this.radTerminationCriteria_Time.Location = new System.Drawing.Point(9, 45);
            this.radTerminationCriteria_Time.Name = "radTerminationCriteria_Time";
            this.radTerminationCriteria_Time.Size = new System.Drawing.Size(71, 17);
            this.radTerminationCriteria_Time.TabIndex = 3;
            this.radTerminationCriteria_Time.Text = "Stop after";
            this.radTerminationCriteria_Time.UseVisualStyleBackColor = true;
            this.radTerminationCriteria_Time.CheckedChanged += new System.EventHandler(this.radTerminationcriteria_CheckedChanged);
            // 
            // radTerminationCriteria_Data
            // 
            this.radTerminationCriteria_Data.AutoSize = true;
            this.radTerminationCriteria_Data.Checked = true;
            this.radTerminationCriteria_Data.Location = new System.Drawing.Point(9, 19);
            this.radTerminationCriteria_Data.Name = "radTerminationCriteria_Data";
            this.radTerminationCriteria_Data.Size = new System.Drawing.Size(106, 17);
            this.radTerminationCriteria_Data.TabIndex = 0;
            this.radTerminationCriteria_Data.TabStop = true;
            this.radTerminationCriteria_Data.Text = "Stop when totally";
            this.radTerminationCriteria_Data.UseVisualStyleBackColor = true;
            this.radTerminationCriteria_Data.CheckedChanged += new System.EventHandler(this.radTerminationcriteria_CheckedChanged);
            // 
            // lbl_Static1
            // 
            this.lbl_Static1.AutoSize = true;
            this.lbl_Static1.Location = new System.Drawing.Point(304, 23);
            this.lbl_Static1.Name = "lbl_Static1";
            this.lbl_Static1.Size = new System.Drawing.Size(52, 13);
            this.lbl_Static1.TabIndex = 1;
            this.lbl_Static1.Text = "was sent.";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.numIpTimeToLive);
            this.grpSettings.Controls.Add(this.label24);
            this.grpSettings.Controls.Add(this.chkDontFragment);
            this.grpSettings.Controls.Add(this.numReplyTimeout);
            this.grpSettings.Controls.Add(this.numMaxErrors);
            this.grpSettings.Controls.Add(this.numNumberOfConnections);
            this.grpSettings.Controls.Add(this.numPayloadSize);
            this.grpSettings.Controls.Add(this.cmbPayloadSizeUnit);
            this.grpSettings.Controls.Add(this.label19);
            this.grpSettings.Controls.Add(this.label16);
            this.grpSettings.Controls.Add(this.label5);
            this.grpSettings.Controls.Add(this.label13);
            this.grpSettings.Controls.Add(this.label4);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Location = new System.Drawing.Point(382, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(255, 162);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // numIpTimeToLive
            // 
            this.numIpTimeToLive.ForeColor = System.Drawing.Color.Black;
            this.numIpTimeToLive.Location = new System.Drawing.Point(123, 88);
            this.numIpTimeToLive.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIpTimeToLive.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIpTimeToLive.Name = "numIpTimeToLive";
            this.numIpTimeToLive.Size = new System.Drawing.Size(57, 20);
            this.numIpTimeToLive.TabIndex = 6;
            this.toolTip1.SetToolTip(this.numIpTimeToLive, "IP packet TTL field");
            this.numIpTimeToLive.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "IP Time To Live (TTL)";
            // 
            // chkDontFragment
            // 
            this.chkDontFragment.AutoSize = true;
            this.chkDontFragment.Location = new System.Drawing.Point(9, 138);
            this.chkDontFragment.Name = "chkDontFragment";
            this.chkDontFragment.Size = new System.Drawing.Size(145, 17);
            this.chkDontFragment.TabIndex = 4;
            this.chkDontFragment.Text = "Don\'t fragment IP Packet";
            this.chkDontFragment.UseVisualStyleBackColor = true;
            // 
            // numReplyTimeout
            // 
            this.numReplyTimeout.ForeColor = System.Drawing.Color.Red;
            this.numReplyTimeout.Location = new System.Drawing.Point(123, 64);
            this.numReplyTimeout.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numReplyTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReplyTimeout.Name = "numReplyTimeout";
            this.numReplyTimeout.Size = new System.Drawing.Size(57, 20);
            this.numReplyTimeout.TabIndex = 3;
            this.toolTip1.SetToolTip(this.numReplyTimeout, "Max time to wait for ping reply");
            this.numReplyTimeout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numMaxErrors
            // 
            this.numMaxErrors.ForeColor = System.Drawing.Color.Red;
            this.numMaxErrors.Location = new System.Drawing.Point(123, 112);
            this.numMaxErrors.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxErrors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxErrors.Name = "numMaxErrors";
            this.numMaxErrors.Size = new System.Drawing.Size(57, 20);
            this.numMaxErrors.TabIndex = 3;
            this.numMaxErrors.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numNumberOfConnections
            // 
            this.numNumberOfConnections.Location = new System.Drawing.Point(123, 17);
            this.numNumberOfConnections.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numNumberOfConnections.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfConnections.Name = "numNumberOfConnections";
            this.numNumberOfConnections.Size = new System.Drawing.Size(57, 20);
            this.numNumberOfConnections.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numNumberOfConnections, "Number of concurrent connections");
            this.numNumberOfConnections.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPayloadSize
            // 
            this.numPayloadSize.Location = new System.Drawing.Point(123, 41);
            this.numPayloadSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPayloadSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPayloadSize.Name = "numPayloadSize";
            this.numPayloadSize.Size = new System.Drawing.Size(57, 20);
            this.numPayloadSize.TabIndex = 1;
            this.numPayloadSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbPayloadSizeUnit
            // 
            this.cmbPayloadSizeUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPayloadSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayloadSizeUnit.FormattingEnabled = true;
            this.cmbPayloadSizeUnit.Items.AddRange(new object[] {
            "Bytes",
            "KB"});
            this.cmbPayloadSizeUnit.Location = new System.Drawing.Point(186, 40);
            this.cmbPayloadSizeUnit.Name = "cmbPayloadSizeUnit";
            this.cmbPayloadSizeUnit.Size = new System.Drawing.Size(59, 21);
            this.cmbPayloadSizeUnit.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(185, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Sec.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Errors.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reply timeout:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Stop sending after";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Packet payload size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Connections:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStart.ForeColor = System.Drawing.Color.Blue;
            this.btnStart.Location = new System.Drawing.Point(429, 412);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStop.ForeColor = System.Drawing.Color.Blue;
            this.btnStop.Location = new System.Drawing.Point(322, 412);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(536, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.AllowUserToOrderColumns = true;
            this.dgvStatistics.AllowUserToResizeRows = false;
            this.dgvStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvStatistics.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatistics.ColumnHeadersHeight = 25;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Connection,
            this.Col_SentPackets,
            this.Col_Replies,
            this.Col_LossRate,
            this.Col_AvgRtt,
            this.Col_Errors});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistics.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatistics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStatistics.Location = new System.Drawing.Point(12, 180);
            this.dgvStatistics.MultiSelect = false;
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.RowHeadersVisible = false;
            this.dgvStatistics.RowTemplate.Height = 18;
            this.dgvStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatistics.ShowCellToolTips = false;
            this.dgvStatistics.Size = new System.Drawing.Size(364, 215);
            this.dgvStatistics.TabIndex = 3;
            // 
            // grpStatistics
            // 
            this.grpStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpStatistics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpStatistics.Controls.Add(this.lblAvrageRtt);
            this.grpStatistics.Controls.Add(this.label11);
            this.grpStatistics.Controls.Add(this.lblRecivedData);
            this.grpStatistics.Controls.Add(this.lblElapsedTime);
            this.grpStatistics.Controls.Add(this.lblTotalErrors);
            this.grpStatistics.Controls.Add(this.lblSentData);
            this.grpStatistics.Controls.Add(this.cmbSentDataUnit);
            this.grpStatistics.Controls.Add(this.lblLossRate);
            this.grpStatistics.Controls.Add(this.lblLostPackets);
            this.grpStatistics.Controls.Add(this.lblTotalReplies);
            this.grpStatistics.Controls.Add(this.lblTotalSentPackets);
            this.grpStatistics.Controls.Add(this.label9);
            this.grpStatistics.Controls.Add(this.label6);
            this.grpStatistics.Controls.Add(this.label12);
            this.grpStatistics.Controls.Add(this.label10);
            this.grpStatistics.Controls.Add(this.label14);
            this.grpStatistics.Controls.Add(this.label22);
            this.grpStatistics.Controls.Add(this.label25);
            this.grpStatistics.Controls.Add(this.label20);
            this.grpStatistics.Controls.Add(this.label2);
            this.grpStatistics.Controls.Add(this.label8);
            this.grpStatistics.Location = new System.Drawing.Point(382, 177);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(255, 220);
            this.grpStatistics.TabIndex = 4;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics";
            // 
            // lblAvrageRtt
            // 
            this.lblAvrageRtt.AutoSize = true;
            this.lblAvrageRtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAvrageRtt.ForeColor = System.Drawing.Color.Blue;
            this.lblAvrageRtt.Location = new System.Drawing.Point(91, 108);
            this.lblAvrageRtt.Name = "lblAvrageRtt";
            this.lblAvrageRtt.Size = new System.Drawing.Size(13, 13);
            this.lblAvrageRtt.TabIndex = 2;
            this.lblAvrageRtt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Average RTT:";
            // 
            // lblRecivedData
            // 
            this.lblRecivedData.AutoSize = true;
            this.lblRecivedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecivedData.ForeColor = System.Drawing.Color.Blue;
            this.lblRecivedData.Location = new System.Drawing.Point(91, 154);
            this.lblRecivedData.Name = "lblRecivedData";
            this.lblRecivedData.Size = new System.Drawing.Size(13, 13);
            this.lblRecivedData.TabIndex = 0;
            this.lblRecivedData.Text = "0";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblElapsedTime.ForeColor = System.Drawing.Color.Green;
            this.lblElapsedTime.Location = new System.Drawing.Point(91, 176);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(13, 13);
            this.lblElapsedTime.TabIndex = 0;
            this.lblElapsedTime.Text = "0";
            // 
            // lblTotalErrors
            // 
            this.lblTotalErrors.AutoSize = true;
            this.lblTotalErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalErrors.Location = new System.Drawing.Point(91, 198);
            this.lblTotalErrors.Name = "lblTotalErrors";
            this.lblTotalErrors.Size = new System.Drawing.Size(13, 13);
            this.lblTotalErrors.TabIndex = 0;
            this.lblTotalErrors.Text = "0";
            // 
            // lblSentData
            // 
            this.lblSentData.AutoSize = true;
            this.lblSentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSentData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSentData.Location = new System.Drawing.Point(91, 131);
            this.lblSentData.Name = "lblSentData";
            this.lblSentData.Size = new System.Drawing.Size(13, 13);
            this.lblSentData.TabIndex = 0;
            this.lblSentData.Text = "0";
            // 
            // cmbSentDataUnit
            // 
            this.cmbSentDataUnit.BackColor = System.Drawing.Color.White;
            this.cmbSentDataUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSentDataUnit.FormattingEnabled = true;
            this.cmbSentDataUnit.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cmbSentDataUnit.Location = new System.Drawing.Point(186, 128);
            this.cmbSentDataUnit.MaxDropDownItems = 16;
            this.cmbSentDataUnit.Name = "cmbSentDataUnit";
            this.cmbSentDataUnit.Size = new System.Drawing.Size(59, 21);
            this.cmbSentDataUnit.TabIndex = 0;
            // 
            // lblLossRate
            // 
            this.lblLossRate.AutoSize = true;
            this.lblLossRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLossRate.ForeColor = System.Drawing.Color.Red;
            this.lblLossRate.Location = new System.Drawing.Point(91, 85);
            this.lblLossRate.Name = "lblLossRate";
            this.lblLossRate.Size = new System.Drawing.Size(14, 13);
            this.lblLossRate.TabIndex = 0;
            this.lblLossRate.Text = "0";
            // 
            // lblLostPackets
            // 
            this.lblLostPackets.AutoSize = true;
            this.lblLostPackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLostPackets.ForeColor = System.Drawing.Color.Red;
            this.lblLostPackets.Location = new System.Drawing.Point(91, 62);
            this.lblLostPackets.Name = "lblLostPackets";
            this.lblLostPackets.Size = new System.Drawing.Size(14, 13);
            this.lblLostPackets.TabIndex = 0;
            this.lblLostPackets.Text = "0";
            // 
            // lblTotalReplies
            // 
            this.lblTotalReplies.AutoSize = true;
            this.lblTotalReplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalReplies.ForeColor = System.Drawing.Color.Green;
            this.lblTotalReplies.Location = new System.Drawing.Point(91, 40);
            this.lblTotalReplies.Name = "lblTotalReplies";
            this.lblTotalReplies.Size = new System.Drawing.Size(14, 13);
            this.lblTotalReplies.TabIndex = 0;
            this.lblTotalReplies.Text = "0";
            // 
            // lblTotalSentPackets
            // 
            this.lblTotalSentPackets.AutoSize = true;
            this.lblTotalSentPackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalSentPackets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalSentPackets.Location = new System.Drawing.Point(91, 18);
            this.lblTotalSentPackets.Name = "lblTotalSentPackets";
            this.lblTotalSentPackets.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSentPackets.TabIndex = 0;
            this.lblTotalSentPackets.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Recived data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(183, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "MilliSeconds";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(185, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Seconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Elapsed time:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Totall errors:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 131);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Sent data:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Loss rate:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Lost packets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reply:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sent packets:";
            // 
            // timStatistics
            // 
            this.timStatistics.Interval = 1000;
            this.timStatistics.Tick += new System.EventHandler(this.timStatistics_Tick);
            // 
            // Col_Connection
            // 
            this.Col_Connection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Connection.HeaderText = "#";
            this.Col_Connection.Name = "Col_Connection";
            this.Col_Connection.ReadOnly = true;
            this.Col_Connection.ToolTipText = "Connection Number";
            this.Col_Connection.Width = 30;
            // 
            // Col_SentPackets
            // 
            this.Col_SentPackets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_SentPackets.HeaderText = "Sent Packets";
            this.Col_SentPackets.Name = "Col_SentPackets";
            this.Col_SentPackets.ReadOnly = true;
            this.Col_SentPackets.ToolTipText = "Sent ICMP packets";
            this.Col_SentPackets.Width = 80;
            // 
            // Col_Replies
            // 
            this.Col_Replies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Replies.HeaderText = "Replies";
            this.Col_Replies.Name = "Col_Replies";
            this.Col_Replies.ReadOnly = true;
            this.Col_Replies.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Replies.ToolTipText = "Number of replied ICMP packets";
            this.Col_Replies.Width = 60;
            // 
            // Col_LossRate
            // 
            this.Col_LossRate.HeaderText = "Loss Rate";
            this.Col_LossRate.Name = "Col_LossRate";
            this.Col_LossRate.ReadOnly = true;
            this.Col_LossRate.ToolTipText = "Loss Rate";
            this.Col_LossRate.Width = 65;
            // 
            // Col_AvgRtt
            // 
            this.Col_AvgRtt.HeaderText = "Avg RTT";
            this.Col_AvgRtt.Name = "Col_AvgRtt";
            this.Col_AvgRtt.ReadOnly = true;
            this.Col_AvgRtt.ToolTipText = "Average Round Trip Time (in milliseconds)";
            this.Col_AvgRtt.Width = 65;
            // 
            // Col_Errors
            // 
            this.Col_Errors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Errors.HeaderText = "Errors";
            this.Col_Errors.Name = "Col_Errors";
            this.Col_Errors.ReadOnly = true;
            this.Col_Errors.ToolTipText = "Number of errors that has occurred in this connection while sending packets";
            this.Col_Errors.Width = 60;
            // 
            // FormIcmpTrafficGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(649, 453);
            this.Controls.Add(this.grpStatistics);
            this.Controls.Add(this.dgvStatistics);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpTerminationCriteria);
            this.Controls.Add(this.grpDestination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(665, 700);
            this.MinimumSize = new System.Drawing.Size(665, 491);
            this.Name = "FormIcmpTrafficGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ICMP Traffic Generator (Ping)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUDPTrafficGenerator_FormClosing);
            this.Load += new System.EventHandler(this.FormUDPTrafficGenerator_Load);
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.grpTerminationCriteria.ResumeLayout(false);
            this.grpTerminationCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExecuteDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataUnitsToSend)).EndInit();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIpTimeToLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReplyTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayloadSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.GroupBox grpTerminationCriteria;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.NumericUpDown numPayloadSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPayloadSizeUnit;
        private System.Windows.Forms.RadioButton radTerminationCriteria_Data;
        private System.Windows.Forms.NumericUpDown numDataUnitsToSend;
        private System.Windows.Forms.ComboBox cmbDataSizeUnit;
        private System.Windows.Forms.Label lbl_Static1;
        private System.Windows.Forms.NumericUpDown numExecuteDuration;
        private System.Windows.Forms.ComboBox cmbTimeUnit;
        private System.Windows.Forms.RadioButton radTerminationCriteria_Time;
        private System.Windows.Forms.RadioButton radTerminationCriteria_None;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.Label lblTotalSentPackets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalErrors;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numMaxErrors;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timStatistics;
        private System.Windows.Forms.Label lblSentData;
        private System.Windows.Forms.Label lblRecivedData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalReplies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numReplyTimeout;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLostPackets;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblLossRate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbSentDataUnit;
        private System.Windows.Forms.CheckBox chkDontFragment;
        private System.Windows.Forms.NumericUpDown numIpTimeToLive;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown numNumberOfConnections;
        private System.Windows.Forms.Label lblAvrageRtt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SentPackets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Replies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LossRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AvgRtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Errors;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}