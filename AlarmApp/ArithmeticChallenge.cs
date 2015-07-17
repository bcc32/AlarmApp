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
    public partial class ArithmeticChallenge : Challenge
    {
        private int numProblems;
        private ArithmeticProblem[] problems;
        private Label[] lblProblems;
        private TextBox[] tbxProblems;

        public ArithmeticChallenge(DifficultyLevel level, int numProblems) : base()
        {
            InitializeComponent();
            this.numProblems = numProblems;
            tblProblems.RowCount = numProblems;
            problems = new ArithmeticProblem[numProblems];
            lblProblems = new Label[numProblems];
            tbxProblems = new TextBox[numProblems];

            for (int i = 0; i < numProblems; i++)
            {
                problems[i] = ArithmeticProblem.MakeRandomProblem(level);

                lblProblems[i] = new Label();
                lblProblems[i].Text = problems[i].ToString();
                tblProblems.Controls.Add(lblProblems[i], 0, i);

                tbxProblems[i] = new TextBox();
                tbxProblems[i].TextChanged += ArithmeticChallenge_TextChanged;
                tblProblems.Controls.Add(tbxProblems[i], 1, i);
            }
        }

        private void ArithmeticChallenge_TextChanged(object sender, EventArgs e)
        {
            CheckAnswers();
        }

        private void CheckAnswers()
        {
            bool done = true;
            for (int i = 0; i < numProblems; i++)
            {
                lblProblems[i].Enabled = true;
                decimal submission = 0;
                if (Decimal.TryParse(tbxProblems[i].Text, out submission) && problems[i].Answer == submission)
                    lblProblems[i].Enabled = false;
                else
                    done = false;
            }
            if (done)
                Complete();
        }
    }
}
