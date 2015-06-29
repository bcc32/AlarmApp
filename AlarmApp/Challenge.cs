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
        private string challengeText;

        public delegate void ChallengeCompletedHandler(object sender, EventArgs e);
        public event ChallengeCompletedHandler Completed;

        public Challenge(string filename)
        {
            InitializeComponent();
            this.filename = filename;
            lbl_ChallengeText.Text = challengeText = new System.IO.StreamReader(filename).ReadToEnd();
        }

        private void Challenge_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void tbx_Answer_TextChanged(object sender, EventArgs e)
        {
            // TODO cleanup
            if (!challengeText.StartsWith(tbx_Answer.Text))
            {
                int firstDiff = -1;
                for (firstDiff = 0; firstDiff < tbx_Answer.Text.Length && firstDiff < challengeText.Length; firstDiff++)
                    if (tbx_Answer.Text[firstDiff] != challengeText[firstDiff])
                        break;
                int cutoff = tbx_Answer.Text.LastIndexOf('\n', firstDiff);
                tbx_Answer.Text = tbx_Answer.Text.Substring(0, cutoff + 1);
                tbx_Answer.SelectionStart = tbx_Answer.Text.Length;
                tbx_Answer.SelectionLength = 0;
            }
            else if (challengeText.Equals(tbx_Answer.Text))
            {
                Completed(this, new EventArgs());
                this.FormClosing -= Challenge_FormClosing;
                this.Close();
            }
        }
    }
}
