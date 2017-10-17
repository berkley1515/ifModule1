namespace ifModule1
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
            this.enterButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(191, 124);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 37);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(191, 88);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(75, 20);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputLabel
            // 
            this.inputLabel.Location = new System.Drawing.Point(85, 91);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(100, 23);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input and Integer";
            // 
            // outputLabel1
            // 
            this.outputLabel1.Location = new System.Drawing.Point(43, 194);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(142, 27);
            this.outputLabel1.TabIndex = 3;
            // 
            // outputLabel2
            // 
            this.outputLabel2.Location = new System.Drawing.Point(43, 232);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(142, 27);
            this.outputLabel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.enterButton);
            this.Name = "Form1";
            this.Text = "If statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
    }
}

