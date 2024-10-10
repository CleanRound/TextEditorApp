namespace WinFormsApp17
{
    partial class ReplaceDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnFindNext;

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
            this.lblFind = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblFind
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(12, 15);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(61, 13);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find Text:";

            // lblReplace
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(12, 41);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(80, 13);
            this.lblReplace.TabIndex = 1;
            this.lblReplace.Text = "Replace With:";

            // txtFind
            this.txtFind.Location = new System.Drawing.Point(98, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(281, 20);
            this.txtFind.TabIndex = 2;

            // txtReplace
            this.txtReplace.Location = new System.Drawing.Point(98, 38);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(281, 20);
            this.txtReplace.TabIndex = 3;

            // Find Next Button
            this.btnFindNext.Location = new System.Drawing.Point(61, 64);  // Aligned horizontally
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 7;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.FindNextButton_Click);

            // Replace All Button
            this.btnReplaceAll.Location = new System.Drawing.Point(142, 64);  // Aligned horizontally
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 6;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.ReplaceAllButton_Click);

            // Cancel Button
            this.btnCancel.Location = new System.Drawing.Point(304, 64);  // Aligned horizontally
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler((sender, e) => this.Close());

            // Replace Button
            this.btnReplace.Location = new System.Drawing.Point(223, 64);  // Aligned horizontally
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.ReplaceButton_Click);

            // ReplaceDialog
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 97);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
