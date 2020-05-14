using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhiteNet
{
    public partial class FormNetworkInterfaces : Form
    {
        public FormNetworkInterfaces()
        {
            InitializeComponent();
        }

        private void FormNetworkInterfaces_Load(object sender, EventArgs e)
        {
            lblNumberOfInterfaces.Text = NetMonitor.DeviceList.Count().ToString();

            foreach (SharpPcap.ICaptureDevice dev in NetMonitor.DeviceList)
                cmbNetInterface.Items.Add(dev.Name);

            if (NetMonitor.DeviceList.Count() > 0)
                cmbNetInterface.SelectedIndex = 0;
            txtNetworkInterfaces.SelectionStart = 0;
            txtNetworkInterfaces.SelectionLength = 0;
        }

        private void cmbNetInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            String newLine = System.Environment.NewLine;
            String interfaceDescription;

            interfaceDescription = NetMonitor.DeviceList[((ComboBox)sender).SelectedIndex].ToString().Replace("\n", newLine);
            txtNetworkInterfaces.Text = interfaceDescription;
        }
    }
}
