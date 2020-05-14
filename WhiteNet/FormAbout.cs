using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;


namespace WhiteNet
{
    public partial class FormAbout : Form
    {
        public Form MainForm { set; get; }

        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            this.Left = MainForm.Left + Math.Abs(MainForm.Width - this.Width) / 2;
            this.Top = MainForm.Top + Math.Abs(MainForm.Height - this.Height) / 2;
        }

        private void FormAbout_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
