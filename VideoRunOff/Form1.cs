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
        HashSet<string> timeStempHashset = new HashSet<string>();
        HashSet<string> StationHashset = new HashSet<string>();
        HashSet<string> SignalHashset = new HashSet<string>();
        HashSet<string> StatusHashset = new HashSet<string>();
        List<logFileData> logfiledataList = new List<logFileData>(); 


        public Form1()
        {
            InitializeComponent();
            videoplayers = new AxWMPLib.AxWindowsMediaPlayer[] { WMPlayer1, WMPlayer2, WMPlayer3, WMPlayer4 };

            for (int i = 0; i < videoplayers.Count(); i++)
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

                string VideosupportedExtensions = "*.m4v,*.mp4,*.mov";
                int i = 0;
                foreach (string videoFile in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Where(s => VideosupportedExtensions.Contains(Path.GetExtension(s).ToLower())))
                {
                    videoplayers[i].URL = videoFile.ToString();
                    i++; 
                    if (i>videoplayers.Count()) i = 0; 
                }

                string logFilesupportedExtensions = "*.txt";
                foreach (string LogFile in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Where(s => logFilesupportedExtensions.Contains(Path.GetExtension(s).ToLower())))
                {
                    readLogFile(LogFile);
                    break;
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
            openFileDialog.Filter = " Watch logs|*.txt";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string logFileName;
                logFileName = openFileDialog.FileName;
                readLogFile(logFileName);
            }
        }

        private void readLogFile(string logFileName)
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(logFileName);

            foreach (string line in lines)
            {
                if (line.Substring(0, 5) == "GM IT")
                {
                    continue;
                }
                // Use a tab to indent each line of the file.
                String TempString = line;
                string timeStemp = TempString.Substring(1, 23);
                TempString = TempString.Substring(47);
                string station = TempString.Substring(0, 6);
                TempString = TempString.Substring(6);
                string signal = TempString.Substring(0, TempString.IndexOf(','));
                TempString = TempString.Substring(TempString.IndexOf(','));
                string status = TempString.Substring(1, TempString.IndexOf('"') - 1);
                TempString = null;

                timeStempHashset.Add("");
                StationHashset.Add("");
                SignalHashset.Add("");
                StatusHashset.Add("");
                timeStempHashset.Add(timeStemp);
                StationHashset.Add(station);
                SignalHashset.Add(signal);
                StatusHashset.Add(status);

                logfiledataList.Add(new logFileData
                {
                    TimeStemp = timeStemp,
                    Station = station,
                    Signal = signal,
                    Status = status
                });
            }

            LoadListView();
            FillFilterComboBox(StationHashset, CBStations);
            FillFilterComboBox(SignalHashset, CBSignal);
            FillFilterComboBox(StatusHashset, CBStatus);
        }

        private void LoadListView()
        {
            ListViewLogFile.Items.Clear();
            for (int i = 0; i < logfiledataList.Count; i++)
            {
                ListViewItem LVItem = new ListViewItem();
                LVItem.Text = logfiledataList[i].TimeStemp;
                LVItem.SubItems.Add(logfiledataList[i].Station);
                LVItem.SubItems.Add(logfiledataList[i].Signal);
                LVItem.SubItems.Add(logfiledataList[i].Status);
                ListViewLogFile.Items.Add(LVItem);
            }
        }

        private void FillFilterComboBox(HashSet<string> tempHashSet, ComboBox tempCombobox)
        {
            List<string> tempList = tempHashSet.ToList();
            BindingSource theBindingSource = new BindingSource();
            theBindingSource.DataSource = tempList;  
            tempCombobox.DataSource = theBindingSource.DataSource;
        }

        private void CBStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //string FiltedStation = (string)CBStations.SelectedItem;

            ////List<string> filteredList = new List<string>();
            ////filteredList = FilterSelectionChanged(CBStations.Text, CBSignal.Text, CBStatus.Text); 
            FilterSelectionChanged(CBStations.Text, CBSignal.Text, CBStatus.Text);
            string oldCBSignalVlue = CBSignal.Text;
            string oldCBStatusVlue = CBStatus.Text;
            FillFilterComboBox(SignalHashset, CBSignal);
            CBSignal.Text = oldCBSignalVlue;
            CBStatus.Text =  oldCBStatusVlue;
            FillFilterComboBox(StatusHashset, CBStatus);
        }

        private void CBSignal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //string Filtedsignal = (string)CBSignal.SelectedItem;
            //CBSignal.Text = Filtedsignal;
            CBStatus.Text = ""; 
            FilterSelectionChanged(CBStations.Text, CBSignal.Text, CBStatus.Text);
            //FillFilterComboBox(SignalHashset, CBSignal);
            FillFilterComboBox(StatusHashset, CBStatus);
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSelectionChanged(CBStations.Text, CBSignal.Text, CBStatus.Text);
        }

        public void FilterSelectionChanged(string FilterStation, string FilterSignal, string FilterStatus)
        {
            if (FilterStation != "" && FilterSignal == "" && FilterStatus == "")
            {
                SignalHashset.Clear();
                StatusHashset.Clear();

                ListViewLogFile.Items.Clear();
                for (int i = 0; i < logfiledataList.Count; i++)
                {
                    if (logfiledataList[i].Station == FilterStation)
                    {
                        ListViewItem LVItem = new ListViewItem();
                        LVItem.Text = logfiledataList[i].TimeStemp;
                        LVItem.SubItems.Add(logfiledataList[i].Station);
                        LVItem.SubItems.Add(logfiledataList[i].Signal);
                        LVItem.SubItems.Add(logfiledataList[i].Status);
                        ListViewLogFile.Items.Add(LVItem);

                        SignalHashset.Add("");
                        StatusHashset.Add("");
                        SignalHashset.Add(logfiledataList[i].Signal);
                        StatusHashset.Add(logfiledataList[i].Status);
                    }
                }
            }
            else if (FilterStation != "" && FilterSignal != "" && FilterStatus != "")
            {
                SignalHashset.Clear();
                StatusHashset.Clear();

                ListViewLogFile.Items.Clear();
                for (int i = 0; i < logfiledataList.Count; i++)
                {
                    if (logfiledataList[i].Station == FilterStation && logfiledataList[i].Signal == FilterSignal && logfiledataList[i].Status == FilterStatus)
                    {
                        ListViewItem LVItem = new ListViewItem();
                        LVItem.Text = logfiledataList[i].TimeStemp;
                        LVItem.SubItems.Add(logfiledataList[i].Station);
                        LVItem.SubItems.Add(logfiledataList[i].Signal);
                        LVItem.SubItems.Add(logfiledataList[i].Status);
                        ListViewLogFile.Items.Add(LVItem);

                        StatusHashset.Add("");
                        StatusHashset.Add(logfiledataList[i].Status);
                    }
                }

             }
            else if (FilterStation != "" && FilterSignal != "" && FilterStatus == "")
            {
                StatusHashset.Clear();
                ListViewLogFile.Items.Clear();
                for (int i = 0; i < logfiledataList.Count; i++)
                {
                    if (logfiledataList[i].Station == FilterStation && logfiledataList[i].Signal == FilterSignal)
                    {
                        ListViewItem LVItem = new ListViewItem();
                        LVItem.Text = logfiledataList[i].TimeStemp;
                        LVItem.SubItems.Add(logfiledataList[i].Station);
                        LVItem.SubItems.Add(logfiledataList[i].Signal);
                        LVItem.SubItems.Add(logfiledataList[i].Status);
                        ListViewLogFile.Items.Add(LVItem);

                        StatusHashset.Add("");
                        StatusHashset.Add(logfiledataList[i].Status);
                    }
                }

            }
        }

        private void ListViewLogFile_DoubleClick(object sender, EventArgs e)
        {
            string ClickedTime = ListViewLogFile.SelectedItems[0].SubItems[0].Text;
            ClickedTime = ClickedTime.Substring(ClickedTime.IndexOf(' ')+1);
            //MessageBox.Show(ClickedTime);
            string firstTimeChar = ClickedTime.Substring(1, 1);
            for (int i = 0; i < videoplayers.Length; i++)
            {
                videoplayers[i].Ctlcontrols.currentPosition = Convert.ToDouble(firstTimeChar);
            }
        }

        private void ListViewLogFile__SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}