namespace WhiteNet
{
    partial class FormUdpTrafficGenerator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUdpTrafficGenerator));
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.numPortNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
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
            this.numMaxErrors = new System.Windows.Forms.NumericUpDown();
            this.numDatagramSize = new System.Windows.Forms.NumericUpDown();
            this.cmbDatagramSizeUnit = new System.Windows.Forms.ComboBox();
            this.cmbNumberOfConnections = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.Col_Connection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SentDatagrams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SentKiloBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.lblSendRate = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.lblTotalErrors = new System.Windows.Forms.Label();
            this.lblTotalSentMegabytes = new System.Windows.Forms.Label();
            this.lblTotalSentKilobytes = new System.Windows.Forms.Label();
            this.lblTotalSentBytes = new System.Windows.Forms.Label();
            this.lblTotalSentDatagrams = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timStatistics = new System.Windows.Forms.Timer(this.components);
            this.grpDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortNumber)).BeginInit();
            this.grpTerminationCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExecuteDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataUnitsToSend)).BeginInit();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatagramSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.grpStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.numPortNumber);
            this.grpDestination.Controls.Add(this.label2);
            this.grpDestination.Controls.Add(this.label1);
            this.grpDestination.Controls.Add(this.txtHost);
            this.grpDestination.Location = new System.Drawing.Point(12, 12);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(364, 54);
            this.grpDestination.TabIndex = 0;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination";
            // 
            // numPortNumber
            // 
            this.numPortNumber.Location = new System.Drawing.Point(293, 20);
            this.numPortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPortNumber.Name = "numPortNumber";
            this.numPortNumber.Size = new System.Drawing.Size(65, 20);
            this.numPortNumber.TabIndex = 1;
            this.numPortNumber.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
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
            this.txtHost.Size = new System.Drawing.Size(198, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.Text = "tabrizu.ac.ir";
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
            "Bytes",
            "Kilobytes",
            "Megabytes",
            "Gigabytes",
            "Datagrams"});
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
            this.grpSettings.Controls.Add(this.numMaxErrors);
            this.grpSettings.Controls.Add(this.numDatagramSize);
            this.grpSettings.Controls.Add(this.cmbDatagramSizeUnit);
            this.grpSettings.Controls.Add(this.cmbNumberOfConnections);
            this.grpSettings.Controls.Add(this.label16);
            this.grpSettings.Controls.Add(this.label13);
            this.grpSettings.Controls.Add(this.label4);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Location = new System.Drawing.Point(382, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(238, 162);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // numMaxErrors
            // 
            this.numMaxErrors.ForeColor = System.Drawing.Color.Red;
            this.numMaxErrors.Location = new System.Drawing.Point(105, 76);
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
            // numDatagramSize
            // 
            this.numDatagramSize.Location = new System.Drawing.Point(105, 48);
            this.numDatagramSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numDatagramSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDatagramSize.Name = "numDatagramSize";
            this.numDatagramSize.Size = new System.Drawing.Size(57, 20);
            this.numDatagramSize.TabIndex = 1;
            this.numDatagramSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmbDatagramSizeUnit
            // 
            this.cmbDatagramSizeUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDatagramSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatagramSizeUnit.FormattingEnabled = true;
            this.cmbDatagramSizeUnit.Items.AddRange(new object[] {
            "Bytes",
            "KB"});
            this.cmbDatagramSizeUnit.Location = new System.Drawing.Point(168, 47);
            this.cmbDatagramSizeUnit.Name = "cmbDatagramSizeUnit";
            this.cmbDatagramSizeUnit.Size = new System.Drawing.Size(59, 21);
            this.cmbDatagramSizeUnit.TabIndex = 2;
            // 
            // cmbNumberOfConnections
            // 
            this.cmbNumberOfConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfConnections.FormattingEnabled = true;
            this.cmbNumberOfConnections.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cmbNumberOfConnections.Location = new System.Drawing.Point(105, 19);
            this.cmbNumberOfConnections.MaxDropDownItems = 16;
            this.cmbNumberOfConnections.Name = "cmbNumberOfConnections";
            this.cmbNumberOfConnections.Size = new System.Drawing.Size(57, 21);
            this.cmbNumberOfConnections.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(165, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Errors.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Stop sending after";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Datagram size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
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
            this.btnStart.Location = new System.Drawing.Point(412, 383);
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
            this.btnStop.Location = new System.Drawing.Point(305, 383);
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
            this.btnClose.Location = new System.Drawing.Point(519, 383);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatistics.ColumnHeadersHeight = 25;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Connection,
            this.Col_SentDatagrams,
            this.Col_SentKiloBytes,
            this.Col_Errors});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistics.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvStatistics.Size = new System.Drawing.Size(364, 184);
            this.dgvStatistics.TabIndex = 3;
            // 
            // Col_Connection
            // 
            this.Col_Connection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Connection.HeaderText = "Connection";
            this.Col_Connection.Name = "Col_Connection";
            this.Col_Connection.ReadOnly = true;
            this.Col_Connection.Width = 70;
            // 
            // Col_SentDatagrams
            // 
            this.Col_SentDatagrams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_SentDatagrams.HeaderText = "Sent Datagrams";
            this.Col_SentDatagrams.Name = "Col_SentDatagrams";
            this.Col_SentDatagrams.ReadOnly = true;
            // 
            // Col_SentKiloBytes
            // 
            this.Col_SentKiloBytes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_SentKiloBytes.HeaderText = "Sent (Kilobytes)";
            this.Col_SentKiloBytes.Name = "Col_SentKiloBytes";
            this.Col_SentKiloBytes.ReadOnly = true;
            this.Col_SentKiloBytes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_SentKiloBytes.Width = 125;
            // 
            // Col_Errors
            // 
            this.Col_Errors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Errors.HeaderText = "Errors";
            this.Col_Errors.Name = "Col_Errors";
            this.Col_Errors.ReadOnly = true;
            this.Col_Errors.Width = 65;
            // 
            // grpStatistics
            // 
            this.grpStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpStatistics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpStatistics.Controls.Add(this.lblSendRate);
            this.grpStatistics.Controls.Add(this.lblElapsedTime);
            this.grpStatistics.Controls.Add(this.lblTotalErrors);
            this.grpStatistics.Controls.Add(this.lblTotalSentMegabytes);
            this.grpStatistics.Controls.Add(this.lblTotalSentKilobytes);
            this.grpStatistics.Controls.Add(this.lblTotalSentBytes);
            this.grpStatistics.Controls.Add(this.lblTotalSentDatagrams);
            this.grpStatistics.Controls.Add(this.label11);
            this.grpStatistics.Controls.Add(this.label7);
            this.grpStatistics.Controls.Add(this.label6);
            this.grpStatistics.Controls.Add(this.label5);
            this.grpStatistics.Controls.Add(this.label15);
            this.grpStatistics.Controls.Add(this.label9);
            this.grpStatistics.Controls.Add(this.label12);
            this.grpStatistics.Controls.Add(this.label10);
            this.grpStatistics.Controls.Add(this.label14);
            this.grpStatistics.Controls.Add(this.label8);
            this.grpStatistics.Location = new System.Drawing.Point(382, 177);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(238, 187);
            this.grpStatistics.TabIndex = 4;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics";
            // 
            // lblSendRate
            // 
            this.lblSendRate.AutoSize = true;
            this.lblSendRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSendRate.ForeColor = System.Drawing.Color.Blue;
            this.lblSendRate.Location = new System.Drawing.Point(80, 123);
            this.lblSendRate.Name = "lblSendRate";
            this.lblSendRate.Size = new System.Drawing.Size(13, 13);
            this.lblSendRate.TabIndex = 0;
            this.lblSendRate.Text = "0";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblElapsedTime.ForeColor = System.Drawing.Color.Green;
            this.lblElapsedTime.Location = new System.Drawing.Point(80, 144);
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
            this.lblTotalErrors.Location = new System.Drawing.Point(80, 163);
            this.lblTotalErrors.Name = "lblTotalErrors";
            this.lblTotalErrors.Size = new System.Drawing.Size(13, 13);
            this.lblTotalErrors.TabIndex = 0;
            this.lblTotalErrors.Text = "0";
            // 
            // lblTotalSentMegabytes
            // 
            this.lblTotalSentMegabytes.AutoSize = true;
            this.lblTotalSentMegabytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalSentMegabytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalSentMegabytes.Location = new System.Drawing.Point(80, 101);
            this.lblTotalSentMegabytes.Name = "lblTotalSentMegabytes";
            this.lblTotalSentMegabytes.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSentMegabytes.TabIndex = 0;
            this.lblTotalSentMegabytes.Text = "0";
            // 
            // lblTotalSentKilobytes
            // 
            this.lblTotalSentKilobytes.AutoSize = true;
            this.lblTotalSentKilobytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalSentKilobytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalSentKilobytes.Location = new System.Drawing.Point(80, 80);
            this.lblTotalSentKilobytes.Name = "lblTotalSentKilobytes";
            this.lblTotalSentKilobytes.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSentKilobytes.TabIndex = 0;
            this.lblTotalSentKilobytes.Text = "0";
            // 
            // lblTotalSentBytes
            // 
            this.lblTotalSentBytes.AutoSize = true;
            this.lblTotalSentBytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalSentBytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalSentBytes.Location = new System.Drawing.Point(80, 59);
            this.lblTotalSentBytes.Name = "lblTotalSentBytes";
            this.lblTotalSentBytes.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSentBytes.TabIndex = 0;
            this.lblTotalSentBytes.Text = "0";
            // 
            // lblTotalSentDatagrams
            // 
            this.lblTotalSentDatagrams.AutoSize = true;
            this.lblTotalSentDatagrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalSentDatagrams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalSentDatagrams.Location = new System.Drawing.Point(80, 38);
            this.lblTotalSentDatagrams.Name = "lblTotalSentDatagrams";
            this.lblTotalSentDatagrams.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSentDatagrams.TabIndex = 0;
            this.lblTotalSentDatagrams.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(163, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Megabytes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(163, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kilobytes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(163, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datagrams";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(163, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bytes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(163, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "MB/sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Send rate:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(163, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Seconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Elapsed time:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Totall errors:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Totall sent:";
            // 
            // timStatistics
            // 
            this.timStatistics.Interval = 1000;
            this.timStatistics.Tick += new System.EventHandler(this.timStatistics_Tick);
            // 
            // FormUDPTrafficGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(632, 424);
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
            this.MaximumSize = new System.Drawing.Size(648, 600);
            this.MinimumSize = new System.Drawing.Size(648, 462);
            this.Name = "FormUDPTrafficGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UDP Traffic Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUDPTrafficGenerator_FormClosing);
            this.Load += new System.EventHandler(this.FormUDPTrafficGenerator_Load);
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortNumber)).EndInit();
            this.grpTerminationCriteria.ResumeLayout(false);
            this.grpTerminationCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExecuteDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataUnitsToSend)).EndInit();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatagramSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPortNumber;
        private System.Windows.Forms.GroupBox grpTerminationCriteria;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.NumericUpDown numDatagramSize;
        private System.Windows.Forms.ComboBox cmbNumberOfConnections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDatagramSizeUnit;
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
        private System.Windows.Forms.Label lblTotalSentBytes;
        private System.Windows.Forms.Label lblTotalSentDatagrams;
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
        private System.Windows.Forms.Label lblTotalSentMegabytes;
        private System.Windows.Forms.Label lblTotalSentKilobytes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SentDatagrams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SentKiloBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Errors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSendRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
    }
}