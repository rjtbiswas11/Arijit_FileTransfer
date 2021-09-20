using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Arijit_FileTransfer
{
    public partial class Form1 : Form
    {
        private ToolTip startSearchButtonToolTip;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            startSearchButtonToolTip = new ToolTip();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(sourcePathTextBox.Text);
            foreach (string sourcePathFileNames in files)
            {
                string sourceFileName = System.IO.Path.GetFileName(sourcePathFileNames);
                string destinationPathFileName = System.IO.Path.Combine(destinationPathTextBox.Text, sourceFileName);
                System.IO.File.Copy(sourcePathFileNames, destinationPathFileName, true);
            }
        }

        private void startServiceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourcePathTextBox.Text) || string.IsNullOrEmpty(destinationPathTextBox.Text) || string.IsNullOrEmpty(timerTextBox.Text))
                return;

            timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = Convert.ToInt32(timerTextBox.Text);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        private void startServiceButton_MouseEnter(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(sourcePathTextBox.Text) || string.IsNullOrEmpty(destinationPathTextBox.Text) || string.IsNullOrEmpty(timerTextBox.Text))
            {
                if (startSearchButtonToolTip != null)
                    startSearchButtonToolTip.SetToolTip(startServiceButton, "Please Select Source,Destination & Polling Time Interval to be Copied");
            }
            else
            {
                startSearchButtonToolTip.RemoveAll();
            }
        }


        private void openSourceDialogButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            sourcePathTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void openDestinationDialogButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            destinationPathTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void stopServiceButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
