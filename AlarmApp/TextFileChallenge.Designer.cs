namespace AlarmApp
{
    partial class TextFileChallenge
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
            this.tbx_Answer = new System.Windows.Forms.TextBox();
            this.pnl_ChallengeText = new System.Windows.Forms.Panel();
            this.lbl_ChallengeText = new System.Windows.Forms.Label();
            this.pnl_ChallengeText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_Answer
            // 
            this.tbx_Answer.Location = new System.Drawing.Point(12, 224);
            this.tbx_Answer.Multiline = true;
            this.tbx_Answer.Name = "tbx_Answer";
            this.tbx_Answer.Size = new System.Drawing.Size(511, 136);
            this.tbx_Answer.TabIndex = 1;
            this.tbx_Answer.TextChanged += new System.EventHandler(this.tbx_Answer_TextChanged);
            // 
            // pnl_ChallengeText
            // 
            this.pnl_ChallengeText.AutoScroll = true;
            this.pnl_ChallengeText.Controls.Add(this.lbl_ChallengeText);
            this.pnl_ChallengeText.Location = new System.Drawing.Point(12, 12);
            this.pnl_ChallengeText.Name = "pnl_ChallengeText";
            this.pnl_ChallengeText.Size = new System.Drawing.Size(511, 206);
            this.pnl_ChallengeText.TabIndex = 2;
            // 
            // lbl_ChallengeText
            // 
            this.lbl_ChallengeText.AutoSize = true;
            this.lbl_ChallengeText.Location = new System.Drawing.Point(3, 0);
            this.lbl_ChallengeText.Name = "lbl_ChallengeText";
            this.lbl_ChallengeText.Size = new System.Drawing.Size(0, 13);
            this.lbl_ChallengeText.TabIndex = 0;
            // 
            // Challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 372);
            this.Controls.Add(this.pnl_ChallengeText);
            this.Controls.Add(this.tbx_Answer);
            this.Name = "Challenge";
            this.Text = "Challenge";
            this.pnl_ChallengeText.ResumeLayout(false);
            this.pnl_ChallengeText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Answer;
        private System.Windows.Forms.Panel pnl_ChallengeText;
        private System.Windows.Forms.Label lbl_ChallengeText;
    }
}