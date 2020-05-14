namespace WhiteNet
{
    partial class FormNetworkInterfaces
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
            this.txtNetworkInterfaces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNetInterface = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfInterfaces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNetworkInterfaces
            // 
            this.txtNetworkInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetworkInterfaces.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNetworkInterfaces.Location = new System.Drawing.Point(0, 69);
            this.txtNetworkInterfaces.Multiline = true;
            this.txtNetworkInterfaces.Name = "txtNetworkInterfaces";
            this.txtNetworkInterfaces.ReadOnly = true;
            this.txtNetworkInterfaces.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNetworkInterfaces.Size = new System.Drawing.Size(492, 298);
            this.txtNetworkInterfaces.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Network Interface:";
            // 
            // cmbNetInterface
            // 
            this.cmbNetInterface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNetInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetInterface.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbNetInterface.FormattingEnabled = true;
            this.cmbNetInterface.Location = new System.Drawing.Point(113, 16);
            this.cmbNetInterface.Name = "cmbNetInterface";
            this.cmbNetInterface.Size = new System.Drawing.Size(362, 21);
            this.cmbNetInterface.TabIndex = 2;
            this.cmbNetInterface.SelectedIndexChanged += new System.EventHandler(this.cmbNetInterface_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Network interface(s) found in this computer.";
            // 
            // lblNumberOfInterfaces
            // 
            this.lblNumberOfInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumberOfInterfaces.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfInterfaces.Location = new System.Drawing.Point(2, 53);
            this.lblNumberOfInterfaces.Name = "lblNumberOfInterfaces";
            this.lblNumberOfInterfaces.Size = new System.Drawing.Size(24, 13);
            this.lblNumberOfInterfaces.TabIndex = 1;
            this.lblNumberOfInterfaces.Text = "0";
            this.lblNumberOfInterfaces.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormNetworkInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 365);
            this.Controls.Add(this.lblNumberOfInterfaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNetInterface);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNetworkInterfaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(850, 850);
            this.MinimumSize = new System.Drawing.Size(200, 0);
            this.Name = "FormNetworkInterfaces";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Network Interfaces";
            this.Load += new System.EventHandler(this.FormNetworkInterfaces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNetworkInterfaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNetInterface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfInterfaces;
    }
}