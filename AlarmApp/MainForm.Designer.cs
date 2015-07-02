﻿namespace AlarmApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_SetAlarm = new System.Windows.Forms.Button();
            this.soundFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_SoundFile = new System.Windows.Forms.Label();
            this.tbx_SoundFileName = new System.Windows.Forms.TextBox();
            this.btn_BrowseSoundFile = new System.Windows.Forms.Button();
            this.lbl_AlarmSet = new System.Windows.Forms.Label();
            this.tbx_ChallengeFileName = new System.Windows.Forms.TextBox();
            this.lbl_Challenge = new System.Windows.Forms.Label();
            this.btn_BrowseChallengeFile = new System.Windows.Forms.Button();
            this.challengeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_TryChallenge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "HH:mm";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(52, 7);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(96, 20);
            this.endTimePicker.TabIndex = 0;
            this.endTimePicker.Value = new System.DateTime(2015, 6, 28, 0, 0, 0, 0);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(13, 13);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(33, 13);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "&Time:";
            // 
            // alarmTimer
            // 
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // btn_SetAlarm
            // 
            this.btn_SetAlarm.Location = new System.Drawing.Point(12, 90);
            this.btn_SetAlarm.Name = "btn_SetAlarm";
            this.btn_SetAlarm.Size = new System.Drawing.Size(256, 23);
            this.btn_SetAlarm.TabIndex = 2;
            this.btn_SetAlarm.Text = "Set &Alarm";
            this.btn_SetAlarm.UseVisualStyleBackColor = true;
            this.btn_SetAlarm.Click += new System.EventHandler(this.btn_SetAlarm_Click);
            // 
            // soundFileDialog
            // 
            this.soundFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.soundFileDialog_FileOk);
            // 
            // lbl_SoundFile
            // 
            this.lbl_SoundFile.AutoSize = true;
            this.lbl_SoundFile.Location = new System.Drawing.Point(13, 36);
            this.lbl_SoundFile.Name = "lbl_SoundFile";
            this.lbl_SoundFile.Size = new System.Drawing.Size(57, 13);
            this.lbl_SoundFile.TabIndex = 3;
            this.lbl_SoundFile.Text = "&Sound file:";
            // 
            // tbx_SoundFileName
            // 
            this.tbx_SoundFileName.Location = new System.Drawing.Point(76, 33);
            this.tbx_SoundFileName.Name = "tbx_SoundFileName";
            this.tbx_SoundFileName.Size = new System.Drawing.Size(111, 20);
            this.tbx_SoundFileName.TabIndex = 4;
            // 
            // btn_BrowseSoundFile
            // 
            this.btn_BrowseSoundFile.Location = new System.Drawing.Point(193, 31);
            this.btn_BrowseSoundFile.Name = "btn_BrowseSoundFile";
            this.btn_BrowseSoundFile.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseSoundFile.TabIndex = 5;
            this.btn_BrowseSoundFile.Text = "&Browse...";
            this.btn_BrowseSoundFile.UseVisualStyleBackColor = true;
            this.btn_BrowseSoundFile.Click += new System.EventHandler(this.btn_BrowseSoundFile_Click);
            // 
            // lbl_AlarmSet
            // 
            this.lbl_AlarmSet.AutoSize = true;
            this.lbl_AlarmSet.Location = new System.Drawing.Point(154, 13);
            this.lbl_AlarmSet.Name = "lbl_AlarmSet";
            this.lbl_AlarmSet.Size = new System.Drawing.Size(55, 13);
            this.lbl_AlarmSet.TabIndex = 6;
            this.lbl_AlarmSet.Text = "Alarm Set!";
            this.lbl_AlarmSet.Visible = false;
            // 
            // tbx_ChallengeFileName
            // 
            this.tbx_ChallengeFileName.Location = new System.Drawing.Point(76, 60);
            this.tbx_ChallengeFileName.Name = "tbx_ChallengeFileName";
            this.tbx_ChallengeFileName.Size = new System.Drawing.Size(111, 20);
            this.tbx_ChallengeFileName.TabIndex = 7;
            // 
            // lbl_Challenge
            // 
            this.lbl_Challenge.AutoSize = true;
            this.lbl_Challenge.Location = new System.Drawing.Point(13, 63);
            this.lbl_Challenge.Name = "lbl_Challenge";
            this.lbl_Challenge.Size = new System.Drawing.Size(57, 13);
            this.lbl_Challenge.TabIndex = 8;
            this.lbl_Challenge.Text = "&Challenge:";
            // 
            // btn_BrowseChallengeFile
            // 
            this.btn_BrowseChallengeFile.Location = new System.Drawing.Point(193, 58);
            this.btn_BrowseChallengeFile.Name = "btn_BrowseChallengeFile";
            this.btn_BrowseChallengeFile.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseChallengeFile.TabIndex = 9;
            this.btn_BrowseChallengeFile.Text = "B&rowse...";
            this.btn_BrowseChallengeFile.UseVisualStyleBackColor = true;
            this.btn_BrowseChallengeFile.Click += new System.EventHandler(this.btn_BrowseChallengeFile_Click);
            // 
            // challengeFileDialog
            // 
            this.challengeFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.challengeFileDialog_FileOk);
            // 
            // btn_TryChallenge
            // 
            this.btn_TryChallenge.Location = new System.Drawing.Point(12, 119);
            this.btn_TryChallenge.Name = "btn_TryChallenge";
            this.btn_TryChallenge.Size = new System.Drawing.Size(256, 23);
            this.btn_TryChallenge.TabIndex = 10;
            this.btn_TryChallenge.Text = "Tr&y Challenge";
            this.btn_TryChallenge.UseVisualStyleBackColor = true;
            this.btn_TryChallenge.Click += new System.EventHandler(this.btn_TryChallenge_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 151);
            this.Controls.Add(this.btn_TryChallenge);
            this.Controls.Add(this.btn_BrowseChallengeFile);
            this.Controls.Add(this.lbl_Challenge);
            this.Controls.Add(this.tbx_ChallengeFileName);
            this.Controls.Add(this.lbl_AlarmSet);
            this.Controls.Add(this.btn_BrowseSoundFile);
            this.Controls.Add(this.tbx_SoundFileName);
            this.Controls.Add(this.lbl_SoundFile);
            this.Controls.Add(this.btn_SetAlarm);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.endTimePicker);
            this.Name = "MainForm";
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Button btn_SetAlarm;
        private System.Windows.Forms.OpenFileDialog soundFileDialog;
        private System.Windows.Forms.Label lbl_SoundFile;
        private System.Windows.Forms.TextBox tbx_SoundFileName;
        private System.Windows.Forms.Button btn_BrowseSoundFile;
        private System.Windows.Forms.Label lbl_AlarmSet;
        private System.Windows.Forms.Label lbl_Challenge;
        private System.Windows.Forms.Button btn_BrowseChallengeFile;
        private System.Windows.Forms.OpenFileDialog challengeFileDialog;
        private System.Windows.Forms.Button btn_TryChallenge;
        private System.Windows.Forms.TextBox tbx_ChallengeFileName;
    }
}
