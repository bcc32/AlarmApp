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
            lbl_ChallengeText.Text = new System.IO.StreamReader(filename).ReadToEnd();
        }

        private void Challenge_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void tbx_Answer_TextChanged(object sender, EventArgs e)
        {
            if (!lbl_ChallengeText.Text.StartsWith(tbx_Answer.Text))
            {
                int cutoff = tbx_Answer.Text.Length > 10 ? 10 : tbx_Answer.Text.Length;
                tbx_Answer.Text = tbx_Answer.Text.Substring(0, tbx_Answer.Text.Length - cutoff);
                tbx_Answer.SelectionStart = tbx_Answer.Text.Length;
                tbx_Answer.SelectionLength = 0;
            }
            else if (lbl_ChallengeText.Text.Equals(tbx_Answer.Text))
            {
                Completed(this, new EventArgs());
                this.FormClosing -= Challenge_FormClosing;
                this.Close();
            }
        }
    }
}
