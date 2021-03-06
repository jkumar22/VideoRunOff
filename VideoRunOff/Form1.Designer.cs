﻿namespace VideoRunOff
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
            this.BtnPlay = new System.Windows.Forms.Button();
            this.LblVideo1File = new System.Windows.Forms.Label();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.WMPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMPlayer4 = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnPause = new System.Windows.Forms.Button();
            this.txtCurrentTimeStemp = new System.Windows.Forms.TextBox();
            this.BtnSetVideoTime = new System.Windows.Forms.Button();
            this.CBVideoSpeed = new System.Windows.Forms.ComboBox();
            this.BtnSetVideoSpeed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CBStations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBSignal = new System.Windows.Forms.ComboBox();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSelectLogFile = new System.Windows.Forms.Button();
            this.ListViewLogFile = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // WMPlayer1
            // 
            this.WMPlayer1.Enabled = true;
            this.WMPlayer1.Location = new System.Drawing.Point(15, 19);
            this.WMPlayer1.Name = "WMPlayer1";
            this.WMPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer1.OcxState")));
            this.WMPlayer1.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer1.TabIndex = 0;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Location = new System.Drawing.Point(6, 19);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Location = new System.Drawing.Point(6, 48);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 3;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // LblVideo1File
            // 
            this.LblVideo1File.AutoSize = true;
            this.LblVideo1File.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblVideo1File.Location = new System.Drawing.Point(87, 24);
            this.LblVideo1File.Name = "LblVideo1File";
            this.LblVideo1File.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblVideo1File.Size = new System.Drawing.Size(126, 13);
            this.LblVideo1File.TabIndex = 4;
            this.LblVideo1File.Text = "Select a Video file to play";
            this.LblVideo1File.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Location = new System.Drawing.Point(177, 268);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(0, 13);
            this.currentStateLabel.TabIndex = 5;
            // 
            // WMPlayer2
            // 
            this.WMPlayer2.Enabled = true;
            this.WMPlayer2.Location = new System.Drawing.Point(292, 19);
            this.WMPlayer2.Name = "WMPlayer2";
            this.WMPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer2.OcxState")));
            this.WMPlayer2.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer2.TabIndex = 6;
            // 
            // WMPlayer3
            // 
            this.WMPlayer3.Enabled = true;
            this.WMPlayer3.Location = new System.Drawing.Point(15, 223);
            this.WMPlayer3.Name = "WMPlayer3";
            this.WMPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer3.OcxState")));
            this.WMPlayer3.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer3.TabIndex = 7;
            // 
            // WMPlayer4
            // 
            this.WMPlayer4.Enabled = true;
            this.WMPlayer4.Location = new System.Drawing.Point(292, 223);
            this.WMPlayer4.Name = "WMPlayer4";
            this.WMPlayer4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer4.OcxState")));
            this.WMPlayer4.Size = new System.Drawing.Size(271, 181);
            this.WMPlayer4.TabIndex = 8;
            // 
            // BtnPause
            // 
            this.BtnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.Location = new System.Drawing.Point(87, 48);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 23);
            this.BtnPause.TabIndex = 10;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click_1);
            // 
            // txtCurrentTimeStemp
            // 
            this.txtCurrentTimeStemp.Location = new System.Drawing.Point(168, 50);
            this.txtCurrentTimeStemp.Name = "txtCurrentTimeStemp";
            this.txtCurrentTimeStemp.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentTimeStemp.TabIndex = 11;
            this.txtCurrentTimeStemp.Text = "0";
            // 
            // BtnSetVideoTime
            // 
            this.BtnSetVideoTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetVideoTime.Location = new System.Drawing.Point(274, 48);
            this.BtnSetVideoTime.Name = "BtnSetVideoTime";
            this.BtnSetVideoTime.Size = new System.Drawing.Size(75, 23);
            this.BtnSetVideoTime.TabIndex = 12;
            this.BtnSetVideoTime.Text = "Set";
            this.BtnSetVideoTime.UseVisualStyleBackColor = true;
            this.BtnSetVideoTime.Click += new System.EventHandler(this.BtnSetVideoTime_Click);
            // 
            // CBVideoSpeed
            // 
            this.CBVideoSpeed.FormattingEnabled = true;
            this.CBVideoSpeed.Items.AddRange(new object[] {
            "-1",
            "-.5",
            ".5",
            "1",
            "2"});
            this.CBVideoSpeed.Location = new System.Drawing.Point(408, 49);
            this.CBVideoSpeed.Name = "CBVideoSpeed";
            this.CBVideoSpeed.Size = new System.Drawing.Size(45, 21);
            this.CBVideoSpeed.TabIndex = 15;
            this.CBVideoSpeed.Text = "2";
            // 
            // BtnSetVideoSpeed
            // 
            this.BtnSetVideoSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetVideoSpeed.Location = new System.Drawing.Point(459, 47);
            this.BtnSetVideoSpeed.Name = "BtnSetVideoSpeed";
            this.BtnSetVideoSpeed.Size = new System.Drawing.Size(95, 23);
            this.BtnSetVideoSpeed.TabIndex = 14;
            this.BtnSetVideoSpeed.Text = "Video Speed";
            this.BtnSetVideoSpeed.UseVisualStyleBackColor = true;
            this.BtnSetVideoSpeed.Click += new System.EventHandler(this.BtnSetVideoSpeed_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(523, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Apply Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // CBStations
            // 
            this.CBStations.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CBStations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBStations.FormattingEnabled = true;
            this.CBStations.Items.AddRange(new object[] {
            ""});
            this.CBStations.Location = new System.Drawing.Point(87, 21);
            this.CBStations.Name = "CBStations";
            this.CBStations.Size = new System.Drawing.Size(95, 21);
            this.CBStations.TabIndex = 23;
            this.CBStations.SelectedIndexChanged += new System.EventHandler(this.CBStations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "OP/Station:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Signal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Status:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBSignal
            // 
            this.CBSignal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CBSignal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBSignal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSignal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBSignal.FormattingEnabled = true;
            this.CBSignal.Location = new System.Drawing.Point(234, 21);
            this.CBSignal.Name = "CBSignal";
            this.CBSignal.Size = new System.Drawing.Size(113, 21);
            this.CBSignal.TabIndex = 30;
            this.CBSignal.SelectedIndexChanged += new System.EventHandler(this.CBSignal_SelectedIndexChanged);
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CBStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Location = new System.Drawing.Point(394, 21);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(123, 21);
            this.CBStatus.TabIndex = 31;
            this.CBStatus.SelectedIndexChanged += new System.EventHandler(this.CBStatus_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CBStatus);
            this.groupBox1.Controls.Add(this.CBStations);
            this.groupBox1.Controls.Add(this.CBSignal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(596, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 56);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Log File";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.WMPlayer4);
            this.groupBox2.Controls.Add(this.WMPlayer3);
            this.groupBox2.Controls.Add(this.WMPlayer2);
            this.groupBox2.Controls.Add(this.currentStateLabel);
            this.groupBox2.Controls.Add(this.WMPlayer1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 430);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plant Floor Videos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.BtnSelectLogFile);
            this.groupBox3.Controls.Add(this.CBVideoSpeed);
            this.groupBox3.Controls.Add(this.BtnSetVideoSpeed);
            this.groupBox3.Controls.Add(this.BtnSetVideoTime);
            this.groupBox3.Controls.Add(this.txtCurrentTimeStemp);
            this.groupBox3.Controls.Add(this.BtnPause);
            this.groupBox3.Controls.Add(this.LblVideo1File);
            this.groupBox3.Controls.Add(this.BtnPlay);
            this.groupBox3.Controls.Add(this.BtnSelect);
            this.groupBox3.Location = new System.Drawing.Point(12, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 83);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // BtnSelectLogFile
            // 
            this.BtnSelectLogFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectLogFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectLogFile.Location = new System.Drawing.Point(459, 14);
            this.BtnSelectLogFile.Name = "BtnSelectLogFile";
            this.BtnSelectLogFile.Size = new System.Drawing.Size(95, 23);
            this.BtnSelectLogFile.TabIndex = 16;
            this.BtnSelectLogFile.Text = "Select Log File";
            this.BtnSelectLogFile.UseVisualStyleBackColor = true;
            this.BtnSelectLogFile.Click += new System.EventHandler(this.BtnSelectLogFile_Click);
            // 
            // ListViewLogFile
            // 
            this.ListViewLogFile.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ListViewLogFile.AllowColumnReorder = true;
            this.ListViewLogFile.AllowDrop = true;
            this.ListViewLogFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewLogFile.FullRowSelect = true;
            this.ListViewLogFile.GridLines = true;
            this.ListViewLogFile.HideSelection = false;
            this.ListViewLogFile.Location = new System.Drawing.Point(596, 83);
            this.ListViewLogFile.MultiSelect = false;
            this.ListViewLogFile.Name = "ListViewLogFile";
            this.ListViewLogFile.Size = new System.Drawing.Size(612, 456);
            this.ListViewLogFile.TabIndex = 35;
            this.ListViewLogFile.UseCompatibleStateImageBehavior = false;
            this.ListViewLogFile.View = System.Windows.Forms.View.Details;
            this.ListViewLogFile.DoubleClick += new System.EventHandler(this.ListViewLogFile_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 557);
            this.Controls.Add(this.ListViewLogFile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "General Motors Video Runoff";
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMPlayer1;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label LblVideo1File;
        private System.Windows.Forms.Label currentStateLabel;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer2;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer3;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer4;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.TextBox txtCurrentTimeStemp;
        private System.Windows.Forms.Button BtnSetVideoTime;
        private System.Windows.Forms.ComboBox CBVideoSpeed;
        private System.Windows.Forms.Button BtnSetVideoSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBStations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBSignal;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView ListViewLogFile;
        private System.Windows.Forms.Button BtnSelectLogFile;
    }
}

