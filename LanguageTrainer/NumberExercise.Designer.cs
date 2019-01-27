namespace LanguageTrainer
{
    partial class NumberExercise
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLesson = new System.Windows.Forms.Label();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.panelExercise = new System.Windows.Forms.TableLayoutPanel();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblQuestionValue = new System.Windows.Forms.Label();
            this.lblAnswerValue = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.QuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.AnswerTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimerValue = new System.Windows.Forms.Label();
            this.panelExercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(691, 25);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(50, 13);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "Time left:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(341, 23);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(226, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Location = new System.Drawing.Point(12, 9);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(44, 13);
            this.lblLesson.TabIndex = 11;
            this.lblLesson.Text = "Lesson:";
            // 
            // cmbLesson
            // 
            this.cmbLesson.DisplayMember = "Text";
            this.cmbLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(12, 25);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(207, 21);
            this.cmbLesson.TabIndex = 10;
            this.cmbLesson.ValueMember = "Value";
            // 
            // panelExercise
            // 
            this.panelExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExercise.ColumnCount = 2;
            this.panelExercise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelExercise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelExercise.Controls.Add(this.lblAnswer, 0, 2);
            this.panelExercise.Controls.Add(this.lblInput, 0, 1);
            this.panelExercise.Controls.Add(this.lblQuestionValue, 1, 0);
            this.panelExercise.Controls.Add(this.lblAnswerValue, 1, 2);
            this.panelExercise.Controls.Add(this.txtAnswer, 1, 1);
            this.panelExercise.Controls.Add(this.lblQuestion, 0, 0);
            this.panelExercise.Location = new System.Drawing.Point(12, 67);
            this.panelExercise.Name = "panelExercise";
            this.panelExercise.RowCount = 3;
            this.panelExercise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelExercise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelExercise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelExercise.Size = new System.Drawing.Size(776, 362);
            this.panelExercise.TabIndex = 15;
            this.panelExercise.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswer.Location = new System.Drawing.Point(3, 253);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(149, 109);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "Answer:";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInput.Location = new System.Drawing.Point(3, 181);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(149, 72);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "To German:";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionValue
            // 
            this.lblQuestionValue.AutoSize = true;
            this.lblQuestionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionValue.Location = new System.Drawing.Point(158, 0);
            this.lblQuestionValue.Name = "lblQuestionValue";
            this.lblQuestionValue.Size = new System.Drawing.Size(615, 181);
            this.lblQuestionValue.TabIndex = 2;
            this.lblQuestionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerValue
            // 
            this.lblAnswerValue.AutoSize = true;
            this.lblAnswerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerValue.Location = new System.Drawing.Point(158, 253);
            this.lblAnswerValue.Name = "lblAnswerValue";
            this.lblAnswerValue.Size = new System.Drawing.Size(615, 109);
            this.lblAnswerValue.TabIndex = 4;
            this.lblAnswerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerValue.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnswer.Location = new System.Drawing.Point(159, 207);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(612, 20);
            this.txtAnswer.TabIndex = 3;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(149, 181);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Translate";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionTimer
            // 
            this.QuestionTimer.Interval = 1000;
            this.QuestionTimer.Tick += new System.EventHandler(this.QuestionTimer_Tick);
            // 
            // AnswerTimer
            // 
            this.AnswerTimer.Interval = 5000;
            // 
            // lblTimerValue
            // 
            this.lblTimerValue.AutoSize = true;
            this.lblTimerValue.Location = new System.Drawing.Point(748, 24);
            this.lblTimerValue.Name = "lblTimerValue";
            this.lblTimerValue.Size = new System.Drawing.Size(0, 13);
            this.lblTimerValue.TabIndex = 16;
            // 
            // NumberExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimerValue);
            this.Controls.Add(this.panelExercise);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.cmbLesson);
            this.Name = "NumberExercise";
            this.Text = "NumberExercise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumberExercise_FormClosing);
            this.Load += new System.EventHandler(this.NumberExercise_Load);
            this.panelExercise.ResumeLayout(false);
            this.panelExercise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.TableLayoutPanel panelExercise;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblQuestionValue;
        private System.Windows.Forms.Label lblAnswerValue;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer QuestionTimer;
        private System.Windows.Forms.Timer AnswerTimer;
        private System.Windows.Forms.Label lblTimerValue;
    }
}