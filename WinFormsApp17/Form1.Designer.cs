namespace WinFormsApp17
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            this.SuspendLayout();

            // richTextBox1
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;

            // MenuStrip
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                new ToolStripMenuItem("File", null, new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("New", null, NewFile_Click),
                    new ToolStripMenuItem("Open", null, OpenFile_Click),
                    new ToolStripMenuItem("Save", null, SaveFile_Click),
                    new ToolStripMenuItem("Save As", null, SaveFileAs_Click),
                    new ToolStripMenuItem("Exit", null, (s, e) => Application.Exit())
                }),
                new ToolStripMenuItem("Edit", null, new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Copy", null, CopyText_Click),
                    new ToolStripMenuItem("Cut", null, CutText_Click),
                    new ToolStripMenuItem("Paste", null, PasteText_Click),
                    new ToolStripMenuItem("Undo", null, Undo_Click),
                    new ToolStripMenuItem("Find", null, Find_Click),
                    new ToolStripMenuItem("Replace", null, Replace_Click)
                }),
                new ToolStripMenuItem("Settings", null, new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Font Color", null, FontColor_Click),
                    new ToolStripMenuItem("Background Color", null, BackgroundColor_Click),
                    new ToolStripMenuItem("Font", null, FontSettings_Click)
                })
            });
            menuStrip1.Location = new System.Drawing.Point(0, 0);

            // ToolStrip
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                new ToolStripButton("New", null, NewFile_Click),
                new ToolStripButton("Open", null, OpenFile_Click),
                new ToolStripButton("Save", null, SaveFile_Click),
                new ToolStripButton("Copy", null, CopyText_Click),
                new ToolStripButton("Cut", null, CutText_Click),
                new ToolStripButton("Paste", null, PasteText_Click),
                new ToolStripButton("Undo", null, Undo_Click),
                new ToolStripButton("Find", null, Find_Click),
                new ToolStripButton("Replace", null, Replace_Click)
            });
            toolStrip1.Location = new System.Drawing.Point(0, 24);

            // ContextMenuStrip
            contextMenuStrip1.Items.AddRange(new ToolStripItem[]
            {
                new ToolStripMenuItem("Copy", null, CopyText_Click),
                new ToolStripMenuItem("Cut", null, CutText_Click),
                new ToolStripMenuItem("Paste", null, PasteText_Click),
                new ToolStripMenuItem("Undo", null, Undo_Click)
            });

            // Form1
            this.Controls.Add(richTextBox1);
            this.Controls.Add(toolStrip1);
            this.Controls.Add(menuStrip1);
            this.MainMenuStrip = menuStrip1;
            this.Text = "Untitled";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
