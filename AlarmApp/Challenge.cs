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
        public delegate void ChallengeCompletedHandler(object sender, EventArgs e);
        public event ChallengeCompletedHandler ChallengeCompleted;
        public Challenge()
        {
            this.FormClosing += Challenge_FormClosing;
        }

        private void Challenge_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        public void Complete()
        {
            ChallengeCompleted(this, new EventArgs());
            this.FormClosing -= Challenge_FormClosing;
            this.Close();
        }
    }
}
