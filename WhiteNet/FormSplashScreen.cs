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
    public partial class FormSplashScreen : Form
    {
        private delegate void DeviceListDelegate();
        private delegate void ShowMainWindowDelegate();
        private bool _errOccured = false;

        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void FormSplashScreen_Shown(object sender, EventArgs e)
        {
            // Get Device List Asynchronously
            DeviceListDelegate del;
            del = GetDeviceList;
            del.BeginInvoke(new AsyncCallback(DeviceList_Callback), null);
        }

        private void GetDeviceList()
        {
            try
            {
                SharpPcap.CaptureDeviceList d = SharpPcap.CaptureDeviceList.Instance;
                NetMonitor.Initialize(d);
            }
            catch (DllNotFoundException)
            {
                _errOccured = true;
                MessageBox.Show("WinPcap is not installed on this computer. please install it." + Environment.NewLine +
                    "You can download it from http://www.winpcap.org","Missing Component...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An unknown error occured while loading components, please reinstall WhiteNet.", "Unknown Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _errOccured = true;
            }
        }

        private void DeviceList_Callback(IAsyncResult ar)
        {
            // This method is ran in second thread, we should call ShowMainWindow() in context of first thread
            ShowMainWindowDelegate d;
            d = ShowMainWindow;
            this.Invoke(d);
        }

        private void ShowMainWindow()
        {
            if (!_errOccured)
            {
                this.Hide();
                FormMain frmMain = new FormMain();
                NetMonitor.MainForm = frmMain;
                frmMain._frmSplashScreen = this;
                frmMain.Show();
            }
            else
            {
                Application.Exit();
            }
       }
    }
}
