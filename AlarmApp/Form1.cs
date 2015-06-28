using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmApp
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wmPlayer;
        Challenge challengeForm;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            wmPlayer = new WMPLib.WindowsMediaPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetAlarm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void challenge_Completed(object sender, EventArgs e)
        {
            StopSound();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            textBox2.Text = openFileDialog2.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            PlaySound();
            label3.Visible = false;
        }

        private void LoopSound(int newState)
        {
            wmPlayer.controls.play();
        }

        private void PlaySound()
        {
            wmPlayer.URL = textBox1.Text;
            wmPlayer.controls.play();
            wmPlayer.PlayStateChange += LoopSound;
            this.FormClosing += Form1_FormClosing;
            challengeForm = new Challenge(textBox2.Text);
            challengeForm.Completed += challenge_Completed;
            challengeForm.ShowDialog(this);
        }

        private void SetAlarm()
        {
            DateTime endTime = dateTimePicker1.Value;
            TimeSpan interval;
            if (DateTime.Now.TimeOfDay < endTime.TimeOfDay)
            {
                interval = endTime.TimeOfDay - DateTime.Now.TimeOfDay;
            }
            else
            {
                interval = (DateTime.Now.Date.AddDays(1) + endTime.TimeOfDay) - DateTime.Now;
            }
            timer1.Interval = (int)interval.TotalMilliseconds;
            timer1.Start();
            label3.Visible = true;
        }

        private void StopSound()
        {
            wmPlayer.PlayStateChange -= LoopSound;
            wmPlayer.controls.stop();
            this.FormClosing -= Form1_FormClosing;
        }
    }
}
