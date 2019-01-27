using System;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            var exerciseForm = new TextExerciseForm(this);
            Visible = false;
            exerciseForm.Show();
        }
    }
}
