using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRunOff
{
    public partial class Form1 : Form
    {
        // Test pushing from work laptop

        public Form1()
        {
            InitializeComponent();
            WMPlayer1.settings.mute = true;
            WMPlayer2.settings.mute = true;
            WMPlayer3.settings.mute = true;
            WMPlayer4.settings.mute = true;
            WMPlayer1.settings.autoStart = false;
            WMPlayer2.settings.autoStart = false;
            WMPlayer3.settings.autoStart = false;
            WMPlayer4.settings.autoStart = false;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.LblVideo1File.Text = openFileDialog.FileName;
                WMPlayer1.URL = LblVideo1File.Text;
                WMPlayer2.URL = LblVideo1File.Text;
                WMPlayer3.URL = LblVideo1File.Text;
                WMPlayer4.URL = LblVideo1File.Text;
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if ((LblVideo1File.Text != "") && ("Playing" != currentStateLabel.Text))
            {
                WMPlayer1.Ctlcontrols.play();
                WMPlayer2.Ctlcontrols.play();
                WMPlayer3.Ctlcontrols.play();
                WMPlayer4.Ctlcontrols.play();
            }
        }

        private void BtnPause_Click_1(object sender, EventArgs e)
        {
            if ((LblVideo1File.Text != "") && ("Paused" != currentStateLabel.Text))
            {
                txtCurrentTimeStemp.Text = WMPlayer1.Ctlcontrols.currentPosition.ToString();
                WMPlayer1.Ctlcontrols.pause();
                WMPlayer2.Ctlcontrols.pause();
                WMPlayer3.Ctlcontrols.pause();
                WMPlayer4.Ctlcontrols.pause();

            }
        }

        private void BtnSetVideoTime_Click(object sender, EventArgs e)
        {
            WMPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(txtCurrentTimeStemp.Text);
            WMPlayer2.Ctlcontrols.currentPosition = Convert.ToDouble(txtCurrentTimeStemp.Text);
            WMPlayer3.Ctlcontrols.currentPosition = Convert.ToDouble(txtCurrentTimeStemp.Text);
            WMPlayer4.Ctlcontrols.currentPosition = Convert.ToDouble(txtCurrentTimeStemp.Text);
        }

    }

}
