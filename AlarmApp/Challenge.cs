using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmApp
{
    public partial class Challenge : Form
    {
        private string filename;

        public delegate void ChallengeCompletedHandler(object sender, EventArgs e);
        public event ChallengeCompletedHandler Completed;

        public Challenge(string filename)
        {
            InitializeComponent();
            this.filename = filename;
            label1.Text = new System.IO.StreamReader(filename).ReadToEnd();
        }

        private void Challenge_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!label1.Text.StartsWith(textBox2.Text))
            {
                int cutoff = textBox2.Text.Length > 10 ? 10 : textBox2.Text.Length;
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - cutoff);
                textBox2.SelectionStart = textBox2.Text.Length;
                textBox2.SelectionLength = 0;
            }
            else if (label1.Text.Equals(textBox2.Text))
            {
                Completed(this, new EventArgs());
                this.FormClosing -= Challenge_FormClosing;
                this.Close();
            }
        }
    }
}
