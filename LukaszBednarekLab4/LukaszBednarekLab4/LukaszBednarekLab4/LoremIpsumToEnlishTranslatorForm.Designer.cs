namespace LukaszBednarekLab4
{
    partial class LoremIpsumToEnlishTranslatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFastTranslation = new System.Windows.Forms.Button();
            this.textBoxUntranslated = new System.Windows.Forms.RichTextBox();
            this.textBoxEnglishTranslation = new System.Windows.Forms.RichTextBox();
            this.buttonSlowTranslation = new System.Windows.Forms.Button();
            this.progressBarTranslation = new System.Windows.Forms.ProgressBar();
            this.labelCurrentThread = new System.Windows.Forms.Label();
            this.labelCurrentThreadCharacter = new System.Windows.Forms.Label();
            this.textBoxCurrentThread = new System.Windows.Forms.TextBox();
            this.textBoxCurrentThreadCharacter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFastTranslation
            // 
            this.buttonFastTranslation.Location = new System.Drawing.Point(324, 86);
            this.buttonFastTranslation.Name = "buttonFastTranslation";
            this.buttonFastTranslation.Size = new System.Drawing.Size(140, 23);
            this.buttonFastTranslation.TabIndex = 0;
            this.buttonFastTranslation.Text = "Fast Translation";
            this.buttonFastTranslation.UseVisualStyleBackColor = true;
            this.buttonFastTranslation.Click += new System.EventHandler(this.ButtonFastTranslation_Click);
            // 
            // textBoxUntranslated
            // 
            this.textBoxUntranslated.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUntranslated.Location = new System.Drawing.Point(22, 24);
            this.textBoxUntranslated.Name = "textBoxUntranslated";
            this.textBoxUntranslated.ReadOnly = true;
            this.textBoxUntranslated.Size = new System.Drawing.Size(280, 305);
            this.textBoxUntranslated.TabIndex = 1;
            this.textBoxUntranslated.Text = "";
            // 
            // textBoxEnglishTranslation
            // 
            this.textBoxEnglishTranslation.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEnglishTranslation.Location = new System.Drawing.Point(488, 24);
            this.textBoxEnglishTranslation.Name = "textBoxEnglishTranslation";
            this.textBoxEnglishTranslation.ReadOnly = true;
            this.textBoxEnglishTranslation.Size = new System.Drawing.Size(280, 305);
            this.textBoxEnglishTranslation.TabIndex = 2;
            this.textBoxEnglishTranslation.Text = "";
            // 
            // buttonSlowTranslation
            // 
            this.buttonSlowTranslation.Location = new System.Drawing.Point(324, 39);
            this.buttonSlowTranslation.Name = "buttonSlowTranslation";
            this.buttonSlowTranslation.Size = new System.Drawing.Size(140, 23);
            this.buttonSlowTranslation.TabIndex = 3;
            this.buttonSlowTranslation.Text = "Slow Translation";
            this.buttonSlowTranslation.UseVisualStyleBackColor = true;
            this.buttonSlowTranslation.Click += new System.EventHandler(this.ButtonSlowTranslation_Click);
            // 
            // progressBarTranslation
            // 
            this.progressBarTranslation.Location = new System.Drawing.Point(187, 368);
            this.progressBarTranslation.Name = "progressBarTranslation";
            this.progressBarTranslation.Size = new System.Drawing.Size(411, 23);
            this.progressBarTranslation.TabIndex = 4;
            // 
            // labelCurrentThread
            // 
            this.labelCurrentThread.AutoSize = true;
            this.labelCurrentThread.Location = new System.Drawing.Point(351, 173);
            this.labelCurrentThread.Name = "labelCurrentThread";
            this.labelCurrentThread.Size = new System.Drawing.Size(86, 15);
            this.labelCurrentThread.TabIndex = 6;
            this.labelCurrentThread.Text = "Current Thread";
            // 
            // labelCurrentThreadCharacter
            // 
            this.labelCurrentThreadCharacter.AutoSize = true;
            this.labelCurrentThreadCharacter.Location = new System.Drawing.Point(324, 229);
            this.labelCurrentThreadCharacter.Name = "labelCurrentThreadCharacter";
            this.labelCurrentThreadCharacter.Size = new System.Drawing.Size(140, 15);
            this.labelCurrentThreadCharacter.TabIndex = 7;
            this.labelCurrentThreadCharacter.Text = "Current Thread Character";
            // 
            // textBoxCurrentThread
            // 
            this.textBoxCurrentThread.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCurrentThread.Location = new System.Drawing.Point(345, 191);
            this.textBoxCurrentThread.Name = "textBoxCurrentThread";
            this.textBoxCurrentThread.ReadOnly = true;
            this.textBoxCurrentThread.Size = new System.Drawing.Size(100, 23);
            this.textBoxCurrentThread.TabIndex = 9;
            // 
            // textBoxCurrentThreadCharacter
            // 
            this.textBoxCurrentThreadCharacter.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCurrentThreadCharacter.Location = new System.Drawing.Point(345, 251);
            this.textBoxCurrentThreadCharacter.Name = "textBoxCurrentThreadCharacter";
            this.textBoxCurrentThreadCharacter.ReadOnly = true;
            this.textBoxCurrentThreadCharacter.Size = new System.Drawing.Size(100, 23);
            this.textBoxCurrentThreadCharacter.TabIndex = 10;
            // 
            // LoremIpsumToEnlishTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCurrentThreadCharacter);
            this.Controls.Add(this.textBoxCurrentThread);
            this.Controls.Add(this.labelCurrentThreadCharacter);
            this.Controls.Add(this.labelCurrentThread);
            this.Controls.Add(this.progressBarTranslation);
            this.Controls.Add(this.buttonSlowTranslation);
            this.Controls.Add(this.textBoxEnglishTranslation);
            this.Controls.Add(this.textBoxUntranslated);
            this.Controls.Add(this.buttonFastTranslation);
            this.Name = "LoremIpsumToEnlishTranslatorForm";
            this.Text = "Lorem Ipsum To Enlish Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonFastTranslation;
        private RichTextBox textBoxUntranslated;
        private RichTextBox textBoxEnglishTranslation;
        private Button buttonSlowTranslation;
        private ProgressBar progressBarTranslation;
        private Label labelCurrentThread;
        private Label labelCurrentThreadCharacter;
        private TextBox textBoxCurrentThread;
        private TextBox textBoxCurrentThreadCharacter;
    }
}