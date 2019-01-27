using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class TextExerciseForm : Form
    {
        private readonly Form _mainForm;

        public TextExerciseForm(Form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void TextExerciseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Visible = true;
        }
    }
}
