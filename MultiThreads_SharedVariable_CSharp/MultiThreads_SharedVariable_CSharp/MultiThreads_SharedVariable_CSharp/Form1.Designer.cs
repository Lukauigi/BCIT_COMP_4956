namespace MultiThreads_SharedVariable_CSharp
{
    partial class FormMain
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
            this.labelNrThreads = new System.Windows.Forms.Label();
            this.labelIncrement = new System.Windows.Forms.Label();
            this.numericUpDownThreadCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIncrement = new System.Windows.Forms.NumericUpDown();
            this.labelSharedVariableValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCurrentThreads = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.textBoxCurrentThreadName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurrentThreads = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrement)).BeginInit();
            this.panelOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNrThreads
            // 
            this.labelNrThreads.AutoSize = true;
            this.labelNrThreads.Location = new System.Drawing.Point(34, 96);
            this.labelNrThreads.Name = "labelNrThreads";
            this.labelNrThreads.Size = new System.Drawing.Size(126, 17);
            this.labelNrThreads.TabIndex = 0;
            this.labelNrThreads.Text = "Number of threads";
            // 
            // labelIncrement
            // 
            this.labelIncrement.AutoSize = true;
            this.labelIncrement.Location = new System.Drawing.Point(34, 189);
            this.labelIncrement.Name = "labelIncrement";
            this.labelIncrement.Size = new System.Drawing.Size(242, 17);
            this.labelIncrement.TabIndex = 1;
            this.labelIncrement.Text = "Increment max value for each thread:";
            // 
            // numericUpDownThreadCount
            // 
            this.numericUpDownThreadCount.Location = new System.Drawing.Point(308, 91);
            this.numericUpDownThreadCount.Name = "numericUpDownThreadCount";
            this.numericUpDownThreadCount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownThreadCount.TabIndex = 2;
            this.numericUpDownThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownIncrement
            // 
            this.numericUpDownIncrement.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIncrement.Location = new System.Drawing.Point(308, 187);
            this.numericUpDownIncrement.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownIncrement.Name = "numericUpDownIncrement";
            this.numericUpDownIncrement.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIncrement.TabIndex = 3;
            this.numericUpDownIncrement.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelSharedVariableValue
            // 
            this.labelSharedVariableValue.AutoSize = true;
            this.labelSharedVariableValue.Location = new System.Drawing.Point(3, 20);
            this.labelSharedVariableValue.Name = "labelSharedVariableValue";
            this.labelSharedVariableValue.Size = new System.Drawing.Size(154, 17);
            this.labelSharedVariableValue.TabIndex = 4;
            this.labelSharedVariableValue.Text = "Shared variable value: ";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(190, 20);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(171, 22);
            this.textBoxValue.TabIndex = 5;
            this.textBoxValue.Text = "0";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(159, 312);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelCurrentThreads
            // 
            this.labelCurrentThreads.AutoSize = true;
            this.labelCurrentThreads.Location = new System.Drawing.Point(3, 107);
            this.labelCurrentThreads.Name = "labelCurrentThreads";
            this.labelCurrentThreads.Size = new System.Drawing.Size(167, 17);
            this.labelCurrentThreads.TabIndex = 7;
            this.labelCurrentThreads.Text = "Current threads running: ";
            // 
            // panelOutput
            // 
            this.panelOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOutput.Controls.Add(this.textBoxCurrentThreadName);
            this.panelOutput.Controls.Add(this.label1);
            this.panelOutput.Controls.Add(this.textBoxCurrentThreads);
            this.panelOutput.Controls.Add(this.labelSharedVariableValue);
            this.panelOutput.Controls.Add(this.labelCurrentThreads);
            this.panelOutput.Controls.Add(this.textBoxValue);
            this.panelOutput.Location = new System.Drawing.Point(478, 30);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(426, 322);
            this.panelOutput.TabIndex = 8;
            // 
            // textBoxCurrentThreadName
            // 
            this.textBoxCurrentThreadName.Location = new System.Drawing.Point(191, 187);
            this.textBoxCurrentThreadName.Name = "textBoxCurrentThreadName";
            this.textBoxCurrentThreadName.Size = new System.Drawing.Size(170, 22);
            this.textBoxCurrentThreadName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current thread:";
            // 
            // textBoxCurrentThreads
            // 
            this.textBoxCurrentThreads.Location = new System.Drawing.Point(191, 104);
            this.textBoxCurrentThreads.Name = "textBoxCurrentThreads";
            this.textBoxCurrentThreads.Size = new System.Drawing.Size(170, 22);
            this.textBoxCurrentThreads.TabIndex = 8;
            this.textBoxCurrentThreads.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 430);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownIncrement);
            this.Controls.Add(this.numericUpDownThreadCount);
            this.Controls.Add(this.labelIncrement);
            this.Controls.Add(this.labelNrThreads);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.Text = "MultiThreads Shared Variable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrement)).EndInit();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNrThreads;
        private System.Windows.Forms.Label labelIncrement;
        private System.Windows.Forms.NumericUpDown numericUpDownThreadCount;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrement;
        private System.Windows.Forms.Label labelSharedVariableValue;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCurrentThreads;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.TextBox textBoxCurrentThreadName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCurrentThreads;
    }
}

