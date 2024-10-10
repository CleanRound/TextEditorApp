using System;
using System.IO;
using System.Windows.Forms;


namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile_Click(sender, e);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                richTextBox1.Text = File.ReadAllText(currentFilePath);
                this.Text = currentFilePath;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileAs_Click(sender, e);
            }
            else
            {
                File.WriteAllText(currentFilePath, richTextBox1.Text);
            }
        }

        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "Untitled.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                File.WriteAllText(currentFilePath, richTextBox1.Text);
                this.Text = currentFilePath;
            }
        }


        private void NewFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFilePath = string.Empty;
            this.Text = "Untitled";
        }

        private void CopyText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.Copy();
        }

        private void CutText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.Cut();
        }

        private void PasteText_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
                richTextBox1.Undo();
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void BackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void FontSettings_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            FindDialog findDialog = new FindDialog(richTextBox1);
            findDialog.Owner = this; // Set the owner to the main form
            findDialog.Show(this);   // Use Show to keep it on top
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            ReplaceDialog replaceDialog = new ReplaceDialog(richTextBox1);
            replaceDialog.Owner = this;
            replaceDialog.Show(this);
        }

    }
}
