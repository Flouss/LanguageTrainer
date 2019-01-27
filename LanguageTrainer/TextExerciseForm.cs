using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class TextExerciseForm : Form
    {
        private const string LESSON_EXTENSION = ".txt";
        private const string TIMER_LABEL_DEFAULT_TEXT = "60";
        private readonly Form _mainForm;
        private readonly string EXERCISE_FOLDER = "TextExercises";
        private readonly string LESSON_PREFIX = "Lesson";
        private List<LessonComboBoxItem> Lessons;
        private Dictionary<string, string> lessonTuples;
        private int IncorrectAnswerCount;
        private int CorrectAnswerCount;

        public TextExerciseForm(Form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void TextExerciseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Visible = true;
        }

        private void TextExerciseForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(EXERCISE_FOLDER))
            {
                if (MessageBox.ShowError($"{EXERCISE_FOLDER} folder not found!") == DialogResult.OK)
                {
                    Close();
                    return;
                }
            }

            Lessons = new List<LessonComboBoxItem>();
            foreach (var lessonFile in Directory.GetFiles(EXERCISE_FOLDER))
            {
                if (Path.GetFileName(lessonFile).StartsWith(LESSON_PREFIX) && Path.GetExtension(lessonFile).Equals(LESSON_EXTENSION, StringComparison.InvariantCultureIgnoreCase))
                {
                    Lessons.Add(new LessonComboBoxItem(Path.GetFileNameWithoutExtension(lessonFile), lessonFile));
                }
            }

            cmbLesson.DataSource = Lessons;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartExercise();
        }

        private void StartExercise()
        {
            lessonTuples = ParseLessonFile(((LessonComboBoxItem)cmbLesson.SelectedItem).Value);
            if (lessonTuples.Count == 0)
                return;

            lblTimerValue.Text = TIMER_LABEL_DEFAULT_TEXT;
            QuestionTimer.Start();
            lblQuestionValue.ForeColor = Color.Black;
            ResetAnswerCounts();
            panelExercise.Visible = true;
            txtAnswer.Focus();
            DisplayNextTuple();
        }

        private void ResetAnswerCounts()
        {
            IncorrectAnswerCount = 0;
            CorrectAnswerCount = 0;
        }

        private void DisplayNextTuple()
        {
            if (lessonTuples.Count == 0)
            {
                ExerciseFinished();
                return;
            }

            var keyValuePair = PopNextTuple();
            lblQuestionValue.Text = keyValuePair.Key;
            lblAnswerValue.Text = keyValuePair.Value;
        }

        private void DisplayScore()
        {
            var total = CorrectAnswerCount + IncorrectAnswerCount;
            lblQuestionValue.Text = $"Score: {CorrectAnswerCount}/{total}";

            if (((float)CorrectAnswerCount) / total < 0.5)
            {
                lblQuestionValue.ForeColor = Color.Red;
            }
            else
            {
                lblQuestionValue.ForeColor = Color.Green;
            }
        }

        private KeyValuePair<string, string> PopNextTuple()
        {
            if (lessonTuples.Count == 0)
            {
                return default(KeyValuePair<string, string>);
            }

            var randomIndex = new Random().Next(0, lessonTuples.Count - 1);
            var keyValuePair = lessonTuples.ElementAt(randomIndex);
            lessonTuples.Remove(keyValuePair.Key);
            return keyValuePair;
        }

        private Dictionary<string, string> ParseLessonFile(string filePath)
        {
            var lessonTuples = new Dictionary<string, string>();

            foreach (var line in File.ReadLines(filePath))
            {
                var lessonTuple = line.Split('=');
                if (lessonTuple.Length != 2)
                {
                    MessageBox.ShowError($"lesson file {filePath} syntax is incorrect, please verify that all lines are: source=target");
                    return new Dictionary<string, string>();
                }
                lessonTuples.Add(lessonTuple[0], lessonTuple[1]);
            }

            return lessonTuples;
        }

        private void txtAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (AnswerTimer.Enabled)
                {
                    AnswerTimer.Stop();
                    NextQuestion();
                }
                else
                {
                    DisplayAnswer();
                    QuestionTimer.Stop();
                }
                e.Handled = true;
            }
        }

        private void DisplayAnswer()
        {
            if (txtAnswer.Text.Equals(lblAnswerValue.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                DisplayAnswerAsCorrect();
                CorrectAnswerCount++;
            }
            else
            {
                DisplayAnswerAsIncorrect();
                IncorrectAnswerCount++;
            }

            AnswerTimer.Start();
        }

        private void DisplayAnswerAsIncorrect()
        {
            lblAnswerValue.Visible = true;
            lblAnswerValue.ForeColor = Color.Red;
        }

        private void DisplayAnswerAsCorrect()
        {
            lblAnswerValue.Visible = true;
            lblAnswerValue.ForeColor = Color.Green;
        }

        private void AnswerTimer_Tick(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void ExerciseFinished()
        {
            CleanUpExerciseFinished();
            DisplayScore();
        }

        private void NextQuestion()
        {
            CleanUpForNextQuestion();
            DisplayNextTuple();
            QuestionTimer.Start();
        }

        private void CleanUpExerciseFinished()
        {
            AnswerTimer.Stop();
            QuestionTimer.Stop();
            lblAnswerValue.Visible = false;
            txtAnswer.Clear();
        }

        private void CleanUpForNextQuestion()
        {
            lblTimerValue.Text = TIMER_LABEL_DEFAULT_TEXT;
            AnswerTimer.Stop();
            txtAnswer.Clear();
            txtAnswer.Focus();
            lblAnswerValue.Visible = false;
        }

        private void QuestionTickTimer_Tick(object sender, EventArgs e)
        {
            var timerValue = int.Parse(lblTimerValue.Text) - 1;
            lblTimerValue.Text = timerValue.ToString();

            if (timerValue > 0 && timerValue <= 10)
            {
                lblTimerValue.ForeColor = Color.Red;
            }
            else if (timerValue == 0)
            {
                DisplayAnswer();
                QuestionTimer.Stop();
            }
            else
            {
                lblTimerValue.ForeColor = Color.Black;
            }
        }
    }
}
