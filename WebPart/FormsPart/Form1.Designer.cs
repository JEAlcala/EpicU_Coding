namespace FormsPart
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
            this.colorLabel = new System.Windows.Forms.Label();
            this.airLabel = new System.Windows.Forms.Label();
            this.balloonColorTextBox = new System.Windows.Forms.TextBox();
            this.airAmountTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(0, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Color";
            this.colorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // airLabel
            // 
            this.airLabel.AutoSize = true;
            this.airLabel.Location = new System.Drawing.Point(0, 30);
            this.airLabel.Name = "airLabel";
            this.airLabel.Size = new System.Drawing.Size(19, 13);
            this.airLabel.TabIndex = 1;
            this.airLabel.Text = "Air";
            // 
            // balloonColorTextBox
            // 
            this.balloonColorTextBox.Location = new System.Drawing.Point(60, -3);
            this.balloonColorTextBox.Name = "balloonColorTextBox";
            this.balloonColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.balloonColorTextBox.TabIndex = 2;
            // 
            // airAmountTextBox
            // 
            this.airAmountTextBox.Location = new System.Drawing.Point(60, 30);
            this.airAmountTextBox.Name = "airAmountTextBox";
            this.airAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.airAmountTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 78);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.airAmountTextBox);
            this.Controls.Add(this.balloonColorTextBox);
            this.Controls.Add(this.airLabel);
            this.Controls.Add(this.colorLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label airLabel;
        private System.Windows.Forms.TextBox balloonColorTextBox;
        private System.Windows.Forms.TextBox airAmountTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button2;
    }
}

