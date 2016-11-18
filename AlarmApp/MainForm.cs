using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmApp
{
    public partial class MainForm : Form
    {
        WMPLib.WindowsMediaPlayer wmPlayer;
        CoreAudioDevice defaultPlaybackDevice;
        Challenge challengeForm;

        public MainForm()
        {
            InitializeComponent();
            soundFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            challengeFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            wmPlayer = new WMPLib.WindowsMediaPlayer();
            defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            alarmTimer.Stop();
            PlaySound();
            lbl_AlarmSet.Visible = false;
        }

        private void btn_SetAlarm_Click(object sender, EventArgs e)
        {
            SetAlarm();
        }

        private void btn_BrowseSoundFile_Click(object sender, EventArgs e)
        {
            soundFileDialog.ShowDialog();
        }

        private void btn_BrowseChallengeFile_Click(object sender, EventArgs e)
        {
            challengeFileDialog.ShowDialog();
        }

        private void btn_TryChallenge_Click(object sender, EventArgs e)
        {
            PlaySound();
        }

        private void challenge_Completed(object sender, EventArgs e)
        {
            StopSound();
        }

        private void challengeFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            tbx_ChallengeFileName.Text = challengeFileDialog.FileName;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void radMathPuzzle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChallengeFileEnabled();
        }

        private void radTextFile_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChallengeFileEnabled();
        }

        private void soundFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            tbx_SoundFileName.Text = soundFileDialog.FileName;
        }

        private TimeSpan IntervalToEndTime()
        {
            DateTime endTime = endTimePicker.Value;
            TimeSpan interval;
            if (DateTime.Now.TimeOfDay < endTime.TimeOfDay)
            {
                interval = endTime.TimeOfDay - DateTime.Now.TimeOfDay;
            }
            else
            {
                interval = (DateTime.Now.Date.AddDays(1) + endTime.TimeOfDay) - DateTime.Now;
            }
            return interval;
        }

        private void LoopSound(int newState)
        {
            wmPlayer.controls.play();
        }

        private void PlaySound()
        {
            if (radTextFile.Checked)
            {
                challengeForm = new TextFileChallenge(tbx_ChallengeFileName.Text);
            }
            else if (radMathPuzzle.Checked)
            {
                challengeForm = new ArithmeticChallenge(DifficultyLevel.MEDIUM, 5);
            }
            else
            {
                return;
            }
            wmPlayer.URL = tbx_SoundFileName.Text;
            wmPlayer.controls.play();
            wmPlayer.PlayStateChange += LoopSound;
            volumeUpTimer.Enabled = true;
            updn_Volume.Enabled = false;
            this.FormClosing += MainForm_FormClosing;
            challengeForm.ChallengeCompleted += challenge_Completed;
            challengeForm.ShowDialog(this);
        }

        private void SetAlarm()
        {
            alarmTimer.Interval = (int)IntervalToEndTime().TotalMilliseconds;
            alarmTimer.Start();
            lbl_AlarmSet.Visible = true;
        }

        private void StopSound()
        {
            wmPlayer.PlayStateChange -= LoopSound;
            wmPlayer.controls.stop();
            this.FormClosing -= MainForm_FormClosing;
            volumeUpTimer.Enabled = false;
            updn_Volume.Enabled = true;
        }

        private void UpdateChallengeFileEnabled()
        {
            tbx_ChallengeFileName.Enabled = radTextFile.Checked;
            btn_BrowseChallengeFile.Enabled = radTextFile.Checked;
        }

        private void volumeUpTimer_Tick(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = (double)updn_Volume.Value;
        }
    }
}
