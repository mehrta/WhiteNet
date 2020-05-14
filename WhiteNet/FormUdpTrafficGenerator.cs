using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WhiteNet
{
    public partial class FormUdpTrafficGenerator : Form
    {
        private delegate void Del();
        private UdpTrafficGenerator _udp = new UdpTrafficGenerator();
        private Int32 _executeDuration;
        private Int32 _elapsedTime;
        private UInt64 _totalSentBytes_old = 0;
        public FormUdpTrafficGenerator()
        {
            InitializeComponent();
            _udp.SendFinished += new UdpTrafficGenerator.SendFinishedEventHandler(_udp_OnSendFinished);
            _udp.TerminationMode = UdpTrafficGenerator.TerminationCriteria.Data;
        }

        private void FormUDPTrafficGenerator_Load(object sender, EventArgs e)
        {
            cmbDataSizeUnit.SelectedIndex = 2;
            cmbTimeUnit.SelectedIndex = 0;
            cmbNumberOfConnections.SelectedIndex = 3;
            cmbDatagramSizeUnit.SelectedIndex = 1;
            numPortNumber.Minimum = IPEndPoint.MinPort;

        }

        private void radTerminationcriteria_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radSender = (RadioButton)sender;
            if (!radSender.Enabled)
                return;

            if (radSender == radTerminationCriteria_None)
            {
                _udp.TerminationMode = UdpTrafficGenerator.TerminationCriteria.None;
                numDataUnitsToSend.Enabled =
                    cmbDataSizeUnit.Enabled =
                    lbl_Static1.Enabled =
                    numExecuteDuration.Enabled =
                    cmbTimeUnit.Enabled = false;
            }
            else if (radSender == radTerminationCriteria_Data)
            {
                _udp.TerminationMode = UdpTrafficGenerator.TerminationCriteria.Data;
                numExecuteDuration.Enabled =
                    cmbTimeUnit.Enabled = false;

                numDataUnitsToSend.Enabled =
                    cmbDataSizeUnit.Enabled =
                    lbl_Static1.Enabled = true;
            }
            else
            {
                _udp.TerminationMode = UdpTrafficGenerator.TerminationCriteria.Time;
                numExecuteDuration.Enabled =
                    cmbTimeUnit.Enabled = true;

                numDataUnitsToSend.Enabled =
                    cmbDataSizeUnit.Enabled =
                    lbl_Static1.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Change some UI elements properties
            grpDestination.Enabled =
            grpTerminationCriteria.Enabled =
            grpSettings.Enabled =
            btnClose.Enabled =
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            lblTotalSentDatagrams.Text = "0";
            lblTotalSentBytes.Text = "0";
            lblTotalSentKilobytes.Text = "0";
            lblTotalSentMegabytes.Text = "0";
            lblSendRate.Text = "0";
            lblElapsedTime.Text = "0";
            lblTotalErrors.Text = "0";


            // Initial UdpTarfficGenerator Object
            _udp.HostName = txtHost.Text;
            _udp.Port = (Int32)numPortNumber.Value;
            _udp.NumberOfConnections = cmbNumberOfConnections.SelectedIndex + 1;
            _udp.DatagramSize = (cmbDatagramSizeUnit.SelectedIndex == 0) ? (UInt32)numDatagramSize.Value : ((UInt32)numDatagramSize.Value * 1024);
            _udp.MaxErrors = (Int32)numMaxErrors.Value;
            if (_udp.TerminationMode == UdpTrafficGenerator.TerminationCriteria.Data)
                switch (cmbDataSizeUnit.SelectedIndex)
                {
                    case 0: // Unit: Byte
                        _udp.TotalBytesToSend = (UInt64)numDataUnitsToSend.Value;
                        break;
                    case 1:// Unit: Kilobyte
                        _udp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * 1024;
                        break;
                    case 2:// Unit: Megabyte
                        _udp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * 1024 * 1024;
                        break;
                    case 3:// Unit: Gigabyte
                        _udp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * 1024 * 1024 * 1024;
                        break;
                    case 4:// Unit: Datagram
                        _udp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * _udp.DatagramSize;
                        break;
                }
            //

            // Add rows to dgvStatistics
            dgvStatistics.Rows.Clear();
            for (int i = 0; i < _udp.NumberOfConnections; i++)
                dgvStatistics.Rows.Add((i + 1).ToString(), "0", "0", "0");
            //

            // Start Sending Data
            _udp.Start();

            // Enable Timer to show statistical informaton
            timStatistics.Enabled = true;
            _elapsedTime = 0;
            _executeDuration = (cmbTimeUnit.SelectedIndex == 0) ? (Int32)numExecuteDuration.Value : (Int32)numExecuteDuration.Value * 60;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Change some UI elements properties
            grpDestination.Enabled =
                grpTerminationCriteria.Enabled =
                grpSettings.Enabled =
                btnClose.Enabled =
                btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblSendRate.Text = "0";

            // disable timer
            timStatistics.Enabled = false;

            // Stop Sending Data
            _udp.Stop();
            _totalSentBytes_old = 0;
        }

        private void timStatistics_Tick(object sender, EventArgs e)
        {
            UpdateStatistics();
            _elapsedTime += (timStatistics.Interval / 1000);
            lblElapsedTime.Text = _elapsedTime.ToString();

            // It's time to stop?
            if (_udp.TerminationMode == UdpTrafficGenerator.TerminationCriteria.Time && _elapsedTime >= _executeDuration)
                btnStop_Click(null, null);
        }

        private void UpdateStatistics()
        {
            UInt64 totalSentDatagrams = 0;
            UInt64 totalSentBytes_new;
            Int32 totalErrors = 0;

            // Update DataGridView
            lock (_udp.SyncLock)
            {
                for (int i = 0; i < _udp.NumberOfConnections; i++)
                {
                    dgvStatistics.Rows[i].Cells[1].Value = _udp.SendStatistics[i].SentDatagrams.ToString();
                    dgvStatistics.Rows[i].Cells[2].Value = ((_udp.SendStatistics[i].SentDatagrams * _udp.DatagramSize) / 1024).ToString();
                    dgvStatistics.Rows[i].Cells[3].Value = _udp.SendStatistics[i].Errors;

                    totalSentDatagrams += _udp.SendStatistics[i].SentDatagrams;
                    totalErrors += _udp.SendStatistics[i].Errors;
                }
                totalSentBytes_new = _udp.TotalSentBytes;
            }

            // Update Labels 
            lblTotalSentDatagrams.Text = totalSentDatagrams.ToString();
            lblTotalSentBytes.Text = totalSentBytes_new.ToString();
            lblSendRate.Text = ((double)(totalSentBytes_new - _totalSentBytes_old) / (1024 * 1024)).ToString("F2");
            lblTotalSentKilobytes.Text = ((double)totalSentBytes_new / 1024).ToString("F2");
            lblTotalSentMegabytes.Text = ((double)totalSentBytes_new / (1024 * 1024)).ToString("F3");
            lblTotalErrors.Text = totalErrors.ToString();
            _totalSentBytes_old = totalSentBytes_new;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _udp_OnSendFinished()
        {
            Del h1 = new Del(UpdateStatistics);
            this.Invoke(h1);

            EventHandler h2 = new EventHandler(btnStop_Click);
            this.Invoke(h2, null, null);
        }

        private void FormUDPTrafficGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnClose.Enabled)
                e.Cancel = true;
        }
    }
}
