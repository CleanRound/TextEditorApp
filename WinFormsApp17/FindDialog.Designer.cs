namespace WinFormsApp17
{
    partial class FindDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radioUp;
        private System.Windows.Forms.RadioButton radioDown;

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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblFind
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(12, 15);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(61, 13);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find Text:";

            // txtFind
            this.txtFind.Location = new System.Drawing.Point(79, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(300, 20);
            this.txtFind.TabIndex = 1;

            // btnFind
            this.btnFind.Location = new System.Drawing.Point(304, 38);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.FindButton_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(223, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler((sender, e) => this.Close());

            // FindDialog
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 71);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.radioUp = new System.Windows.Forms.RadioButton();
            this.radioDown = new System.Windows.Forms.RadioButton();

            // Radio Button for Up
            this.radioUp.AutoSize = true;
            this.radioUp.Location = new System.Drawing.Point(12, 38);
            this.radioUp.Name = "radioUp";
            this.radioUp.Size = new System.Drawing.Size(39, 17);
            this.radioUp.TabIndex = 4;
            this.radioUp.TabStop = true;
            this.radioUp.Text = "Up";
            this.radioUp.UseVisualStyleBackColor = true;

            // Radio Button for Down (default selection)
            this.radioDown.AutoSize = true;
            this.radioDown.Location = new System.Drawing.Point(79, 38);
            this.radioDown.Name = "radioDown";
            this.radioDown.Size = new System.Drawing.Size(53, 17);
            this.radioDown.TabIndex = 5;
            this.radioDown.TabStop = true;
            this.radioDown.Text = "Down";
            this.radioDown.UseVisualStyleBackColor = true;
            this.radioDown.Checked = true; // Default direction is Down

            // Add radio buttons to the form
            this.Controls.Add(this.radioUp);
            this.Controls.Add(this.radioDown);
        }
    }
}
