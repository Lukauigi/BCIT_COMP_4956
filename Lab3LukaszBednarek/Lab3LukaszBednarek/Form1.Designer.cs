
namespace Lab3LukaszBednarek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgramTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ProgramTextBox
            // 
            this.ProgramTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProgramTextBox.Location = new System.Drawing.Point(12, 12);
            this.ProgramTextBox.Name = "ProgramTextBox";
            this.ProgramTextBox.ReadOnly = true;
            this.ProgramTextBox.Size = new System.Drawing.Size(331, 426);
            this.ProgramTextBox.TabIndex = 0;
            this.ProgramTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.ProgramTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ProgramTextBox;
    }
}

