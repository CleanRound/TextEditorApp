using System;
using System.Windows.Forms;

namespace WinFormsApp17
{
    public partial class ReplaceDialog : Form
    {
        private RichTextBox editor;

        public ReplaceDialog(RichTextBox editor)
        {
            InitializeComponent();
            this.editor = editor;
        }

        private int lastFoundIndex = -1;

        private void FindNextButton_Click(object sender, EventArgs e)
        {
            StringComparison comparison = StringComparison.CurrentCultureIgnoreCase;

            int startIndex = editor.SelectionStart + editor.SelectionLength;

            lastFoundIndex = editor.Text.IndexOf(txtFind.Text, startIndex, comparison);

            if (lastFoundIndex == -1)
            {
                lastFoundIndex = editor.Text.IndexOf(txtFind.Text, 0, comparison);
            }

            if (lastFoundIndex != -1)
            {
                editor.Select(lastFoundIndex, txtFind.Text.Length);
                editor.Focus();
            }
            else
            {
                MessageBox.Show("No occurrences found.");
            }
        }


        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (lastFoundIndex != -1 && editor.SelectedText == txtFind.Text)
            {
                editor.SelectedText = txtReplace.Text;
                FindNextButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No text selected to replace.");
            }
        }


        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                editor.Text = editor.Text.Replace(txtFind.Text, txtReplace.Text);
                MessageBox.Show("All occurrences replaced.");
            }
        }
    }
}
