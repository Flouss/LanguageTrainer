
using System.Windows.Forms;

namespace LanguageTrainer
{
    public static class MessageBox
    {
        public static DialogResult ShowError(string content)
        {
            return System.Windows.Forms.MessageBox.Show(content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
