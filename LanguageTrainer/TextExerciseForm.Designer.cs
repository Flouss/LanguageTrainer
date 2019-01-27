namespace LanguageTrainer
{
    partial class TextExerciseForm
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
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmbLesson
            // 
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(21, 33);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(126, 21);
            this.cmbLesson.TabIndex = 0;
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Location = new System.Drawing.Point(21, 14);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(44, 13);
            this.lblLesson.TabIndex = 1;
            this.lblLesson.Text = "Lesson:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(353, 191);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(43, 13);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "lblWord";
            this.lblWord.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(200, 300);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(367, 20);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(361, 373);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer";
            this.lblAnswer.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 120;
            // 
            // TextExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.cmbLesson);
            this.Name = "TextExerciseForm";
            this.Text = "Text Excercise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextExerciseForm_FormClosing);
            this.Load += new System.EventHandler(this.TextExerciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Timer timer;
    }
}