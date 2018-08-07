namespace VideoRunOff
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WMPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnPlayPause = new System.Windows.Forms.Button();
            this.LblVideo1File = new System.Windows.Forms.Label();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.WMPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMPlayer4 = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnPause = new System.Windows.Forms.Button();
            this.txtCurrentTimeStemp = new System.Windows.Forms.TextBox();
            this.BtnSetVideoTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer4)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPlayer1
            // 
            this.WMPlayer1.Enabled = true;
            this.WMPlayer1.Location = new System.Drawing.Point(12, 12);
            this.WMPlayer1.Name = "WMPlayer1";
            this.WMPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer1.OcxState")));
            this.WMPlayer1.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer1.TabIndex = 0;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Location = new System.Drawing.Point(12, 386);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnPlayPause
            // 
            this.BtnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayPause.Location = new System.Drawing.Point(12, 415);
            this.BtnPlayPause.Name = "BtnPlayPause";
            this.BtnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.BtnPlayPause.TabIndex = 3;
            this.BtnPlayPause.Text = "Play";
            this.BtnPlayPause.UseVisualStyleBackColor = true;
            this.BtnPlayPause.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // LblVideo1File
            // 
            this.LblVideo1File.AutoSize = true;
            this.LblVideo1File.Location = new System.Drawing.Point(93, 391);
            this.LblVideo1File.Name = "LblVideo1File";
            this.LblVideo1File.Size = new System.Drawing.Size(126, 13);
            this.LblVideo1File.TabIndex = 4;
            this.LblVideo1File.Text = "Select a Video file to play";
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Location = new System.Drawing.Point(178, 251);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(0, 13);
            this.currentStateLabel.TabIndex = 5;
            // 
            // WMPlayer2
            // 
            this.WMPlayer2.Enabled = true;
            this.WMPlayer2.Location = new System.Drawing.Point(289, 12);
            this.WMPlayer2.Name = "WMPlayer2";
            this.WMPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer2.OcxState")));
            this.WMPlayer2.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer2.TabIndex = 6;
            // 
            // WMPlayer3
            // 
            this.WMPlayer3.Enabled = true;
            this.WMPlayer3.Location = new System.Drawing.Point(12, 199);
            this.WMPlayer3.Name = "WMPlayer3";
            this.WMPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer3.OcxState")));
            this.WMPlayer3.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer3.TabIndex = 7;
            // 
            // WMPlayer4
            // 
            this.WMPlayer4.Enabled = true;
            this.WMPlayer4.Location = new System.Drawing.Point(289, 199);
            this.WMPlayer4.Name = "WMPlayer4";
            this.WMPlayer4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer4.OcxState")));
            this.WMPlayer4.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer4.TabIndex = 8;
            // 
            // BtnPause
            // 
            this.BtnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.Location = new System.Drawing.Point(93, 415);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 23);
            this.BtnPause.TabIndex = 10;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click_1);
            // 
            // txtCurrentTimeStemp
            // 
            this.txtCurrentTimeStemp.Location = new System.Drawing.Point(174, 417);
            this.txtCurrentTimeStemp.Name = "txtCurrentTimeStemp";
            this.txtCurrentTimeStemp.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentTimeStemp.TabIndex = 11;
            // 
            // BtnSetVideoTime
            // 
            this.BtnSetVideoTime.Location = new System.Drawing.Point(281, 417);
            this.BtnSetVideoTime.Name = "BtnSetVideoTime";
            this.BtnSetVideoTime.Size = new System.Drawing.Size(75, 23);
            this.BtnSetVideoTime.TabIndex = 12;
            this.BtnSetVideoTime.Text = "Set";
            this.BtnSetVideoTime.UseVisualStyleBackColor = true;
            this.BtnSetVideoTime.Click += new System.EventHandler(this.BtnSetVideoTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 449);
            this.Controls.Add(this.BtnSetVideoTime);
            this.Controls.Add(this.txtCurrentTimeStemp);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.WMPlayer4);
            this.Controls.Add(this.WMPlayer3);
            this.Controls.Add(this.WMPlayer2);
            this.Controls.Add(this.currentStateLabel);
            this.Controls.Add(this.LblVideo1File);
            this.Controls.Add(this.BtnPlayPause);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.WMPlayer1);
            this.Name = "Form1";
            this.Text = "CITI Video Validation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMPlayer1;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnPlayPause;
        private System.Windows.Forms.Label LblVideo1File;
        private System.Windows.Forms.Label currentStateLabel;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer2;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer3;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer4;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.TextBox txtCurrentTimeStemp;
        private System.Windows.Forms.Button BtnSetVideoTime;
    }
}

