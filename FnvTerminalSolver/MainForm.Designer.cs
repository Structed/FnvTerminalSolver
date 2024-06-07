namespace FnvTerminalSolver
{
    partial class MainForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.labelMinCommonCharacters = new System.Windows.Forms.Label();
            this.textBoxMinimumCommonCharacters = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 234);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Enabled = false;
            this.outputTextBox.Location = new System.Drawing.Point(195, 33);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(483, 234);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // labelMinCommonCharacters
            // 
            this.labelMinCommonCharacters.Location = new System.Drawing.Point(30, 10);
            this.labelMinCommonCharacters.Name = "labelMinCommonCharacters";
            this.labelMinCommonCharacters.Size = new System.Drawing.Size(159, 17);
            this.labelMinCommonCharacters.TabIndex = 3;
            this.labelMinCommonCharacters.Text = "Minimum Common Characters:";
            // 
            // textBoxMinimumCommonCharacters
            // 
            this.textBoxMinimumCommonCharacters.Location = new System.Drawing.Point(195, 7);
            this.textBoxMinimumCommonCharacters.Name = "textBoxMinimumCommonCharacters";
            this.textBoxMinimumCommonCharacters.Size = new System.Drawing.Size(51, 20);
            this.textBoxMinimumCommonCharacters.TabIndex = 4;
            this.textBoxMinimumCommonCharacters.Text = "5";
            this.textBoxMinimumCommonCharacters.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 284);
            this.Controls.Add(this.textBoxMinimumCommonCharacters);
            this.Controls.Add(this.labelMinCommonCharacters);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Text = "Fallout New Vegas Terminal Solver";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelMinCommonCharacters;
        private System.Windows.Forms.TextBox textBoxMinimumCommonCharacters;

        private System.Windows.Forms.RichTextBox outputTextBox;

        private System.Windows.Forms.RichTextBox richTextBox1;

        #endregion
    }
}