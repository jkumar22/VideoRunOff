using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRunOff
{
    public partial class Form1 : Form
    {
        AxWMPLib.AxWindowsMediaPlayer[] videoplayers;

        public Form1()
        {
            InitializeComponent();
            videoplayers = new AxWMPLib.AxWindowsMediaPlayer[] { WMPlayer1, WMPlayer2, WMPlayer3, WMPlayer4 };

            for (int i = 0; i < videoplayers.Length; i++)
            {
                // Disabling Audio, Autostart of the video
                videoplayers[i].settings.mute = true;
                videoplayers[i].settings.autoStart = false;
                videoplayers[i].settings.rate = Convert.ToDouble(CBVideoSpeed.Text); 
            }

            //LVlogFile.Items.AddRange(new string[] {"System.Xml", "System.Net", "System.Runtime.Remoting","System.Web"});
            int columnWidth = 150;
            ListViewLogFile.Columns.Add("Time Stemp", columnWidth);
            ListViewLogFile.Columns.Add("OP/Station", columnWidth);
            ListViewLogFile.Columns.Add("Signal", columnWidth);
            ListViewLogFile.Columns.Add("Status", columnWidth);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // setting each video file in the folder to a media player
                this.LblVideo1File.Text = openFileDialog.FileName;
                string folderPath = Path.GetDirectoryName(openFileDialog.FileName);
                // retriving path and file name for each video file
                string[] fileArray = Directory.GetFiles(folderPath);

                for (int i = 0; i < videoplayers.Length; i++)
                {
                    videoplayers[i].URL = fileArray[i];
                }
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if ((LblVideo1File.Text != "") && ("Playing" != currentStateLabel.Text))
            {
                for (int i = 0; i < videoplayers.Length; i++)
                {
                    videoplayers[i].Ctlcontrols.play();
                    videoplayers[i].settings.rate = Convert.ToDouble(CBVideoSpeed.Text);
                }
            }
        }

        private void BtnPause_Click_1(object sender, EventArgs e)
        {
            if ((LblVideo1File.Text != "") && ("Paused" != currentStateLabel.Text))
            {
                txtCurrentTimeStemp.Text = WMPlayer1.Ctlcontrols.currentPosition.ToString();

                for (int i = 0; i < videoplayers.Length; i++)
                {
                    videoplayers[i].Ctlcontrols.pause();
                }
            }
        }

        private void BtnSetVideoTime_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < videoplayers.Length; i++)
            {
                videoplayers[i].Ctlcontrols.currentPosition = Convert.ToDouble(txtCurrentTimeStemp.Text);
            }
        }

        private void BtnSetVideoSpeed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < videoplayers.Length; i++)
            {
                videoplayers[i].settings.rate = Convert.ToDouble(CBVideoSpeed.Text);
            }
        }

        private void BtnSelectLogFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = " (*watch*.txt) | *watch*.txt";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string logFileName;
                logFileName = openFileDialog.FileName;
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] lines = System.IO.File.ReadAllLines(logFileName);

                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    string timeStemp = line.Substring(1,23);
                    string station = line.Substring(47, 6);
                    string signal = "Test0";//line.Substring(52,line.IndexOf(','));
                    string status = "Test";//line.Substring();
                    ListViewItem LVItem = new ListViewItem();
                    LVItem.Text = timeStemp;
                    LVItem.SubItems.Add(station);
                    LVItem.SubItems.Add(signal);
                    LVItem.SubItems.Add(status);
                    ListViewLogFile.Items.Add(LVItem);
                }

            }
        }
    }

}
