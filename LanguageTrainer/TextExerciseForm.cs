using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class TextExerciseForm : Form
    {
        private const string LESSON_EXTENSION = ".txt";
        private readonly Form _mainForm;
        private readonly string EXERCISE_FOLDER = "TextExercises";
        private readonly string LESSON_PREFIX = "Lesson";
        private List<LessonComboBoxItem> Lessons;
        private Dictionary<string, string> lessonTuples;

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
            lessonTuples = ParseLessonFile(((LessonComboBoxItem)cmbLesson.SelectedItem).Value);
            if (lessonTuples.Count == 0)
                return;

            panelExercise.Visible = true;

            txtAnswer.Focus();

            DisplayNextTuple();

            timer.Start();
        }

        private void DisplayNextTuple()
        {
            var keyValuePair = PopNextTuple();
            lblQuestionValue.Text = keyValuePair.Key;
            lblAnswerValue.Text = keyValuePair.Value;
        }

        private KeyValuePair<string, string> PopNextTuple()
        {
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
    }
}
