using System;
using System.Windows.Forms;

namespace WinFormsApp17
{
    public partial class FindDialog : Form
    {
        private RichTextBox editor;

        public FindDialog(RichTextBox editor)
        {
            InitializeComponent();
            this.editor = editor;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            StringComparison comparison = StringComparison.CurrentCultureIgnoreCase;
            int index;

            if (radioDown.Checked)
            {
                index = editor.Text.IndexOf(txtFind.Text, editor.SelectionStart + editor.SelectionLength, comparison);
                if (index == -1)
                {
                    index = editor.Text.IndexOf(txtFind.Text, 0, comparison);
                }
            }
            else
            {
                index = editor.Text.LastIndexOf(txtFind.Text, editor.SelectionStart, comparison);
                if (index == -1)
                {
                    index = editor.Text.LastIndexOf(txtFind.Text, editor.Text.Length, comparison);
                }
            }

            if (index != -1)
            {
                editor.Select(index, txtFind.Text.Length);
                editor.Focus();
            }
            else
            {
                MessageBox.Show("Text not found.");
            }
        }


    }
}
