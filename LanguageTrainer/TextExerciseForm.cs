﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class TextExerciseForm : Form
    {
        private const string LESSON_EXTENSION = ".txt";
        private readonly Form _mainForm;
        private readonly string EXERCISE_FOLDER = "TextExercises";
        private readonly string LESSON_PREFIX = "Lesson";
        private Dictionary<string, string> LessonsDictionnary;

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

            LessonsDictionnary = new Dictionary<string, string>();
            foreach (var lessonFile in Directory.GetFiles(EXERCISE_FOLDER))
            {
                if (Path.GetFileName(lessonFile).StartsWith(LESSON_PREFIX) && Path.GetExtension(lessonFile).Equals(LESSON_EXTENSION, StringComparison.InvariantCultureIgnoreCase))
                {
                    LessonsDictionnary.Add(Path.GetFileNameWithoutExtension(lessonFile), lessonFile);
                }
            }
        }
    }
}
