using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class NumberExercise : Form
    {
        private const string TIMER_LABEL_DEFAULT_TEXT = "10";
        private readonly MainWindow _mainWindow;
        private Dictionary<string, string> lessonTuples;

        public NumberExercise(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void NumberExercise_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainWindow.Visible = true;
        }

        private void NumberExercise_Load(object sender, System.EventArgs e)
        {
            FillLessonComboBox();
        }

        private void FillLessonComboBox()
        {
            cmbLesson.DataSource = new[] {
                new LessonComboBoxItem("Random Out Loud", "random"),
                new LessonComboBoxItem("Random Writing", "random_write"),
                new LessonComboBoxItem("Phone Numbers", "phone"),
                new LessonComboBoxItem("Zip code", "zip"),
            };
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            switch (cmbLesson.SelectedValue)
            {
                case "random":
                    StartRandom();
                    break;
                case "random_write":
                    StartRandomWrite();
                    break;
                case "phone":
                    StartPhone();
                    break;
                case "zip":
                    StartZip();
                    break;
            }
        }

        private void StartZip()
        {
            throw new NotImplementedException();
        }

        private void StartPhone()
        {
            throw new NotImplementedException();
        }

        private void StartRandomWrite()
        {
            throw new NotImplementedException();
        }

        private void StartRandom()
        {
            panelExercise.Visible = true;
            lblTimerValue.Text = TIMER_LABEL_DEFAULT_TEXT;
            ParseLessonFile();
            NextNumber();
        }

        private void NextNumber()
        {
            var keyValuePair = PickNumber();
            DisplayNextNumber(keyValuePair);
            QuestionTimer.Start();
        }

        private void DisplayNextNumber(KeyValuePair<string, string> keyValuePair)
        {
            lblQuestionValue.Text = keyValuePair.Key;
            lblAnswerValue.Text = keyValuePair.Value;
        }

        private KeyValuePair<string, string> PickNumber()
        {
            var random = new Random().Next(0, 100);
            return lessonTuples.ElementAt(random);
        }

        private void ParseLessonFile()
        {
            lessonTuples = new Dictionary<string, string>();
            foreach (var line in File.ReadLines(@"NumberExercise\NumbersToText.txt"))
            {
                var tuple = line.Split('=');
                if (tuple.Length != 2)
                {
                    if (MessageBox.ShowError("lesson file syntax is incorrect, please verify that all lines are: source=target") == DialogResult.OK)
                    {
                        return;
                    }
                }

                lessonTuples.Add(tuple[0], tuple[1]);
            }
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            var timerValue = int.Parse(lblTimerValue.Text) - 1;
            lblTimerValue.Text = timerValue.ToString();

            if (timerValue > 0 && timerValue <= 5)
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

        private void DisplayAnswer()
        {
            lblAnswerValue.Visible = true;
        }
    }
}
