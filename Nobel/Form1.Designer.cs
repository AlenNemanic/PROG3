namespace Nobel
{
    partial class Okno
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.letoLabel = new System.Windows.Forms.Label();
            this.letoTextBox = new System.Windows.Forms.TextBox();
            this.poisciButton = new System.Windows.Forms.Button();
            this.podrocjeLabel = new System.Windows.Forms.Label();
            this.podrocjeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(407, 18);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(334, 338);
            this.textBox.TabIndex = 0;
            // 
            // letoLabel
            // 
            this.letoLabel.AutoSize = true;
            this.letoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letoLabel.Location = new System.Drawing.Point(43, 150);
            this.letoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.letoLabel.Name = "letoLabel";
            this.letoLabel.Size = new System.Drawing.Size(40, 17);
            this.letoLabel.TabIndex = 1;
            this.letoLabel.Text = "Leto:";
            // 
            // letoTextBox
            // 
            this.letoTextBox.Location = new System.Drawing.Point(115, 149);
            this.letoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.letoTextBox.Name = "letoTextBox";
            this.letoTextBox.Size = new System.Drawing.Size(75, 20);
            this.letoTextBox.TabIndex = 2;
            // 
            // poisciButton
            // 
            this.poisciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poisciButton.Location = new System.Drawing.Point(83, 210);
            this.poisciButton.Margin = new System.Windows.Forms.Padding(2);
            this.poisciButton.Name = "poisciButton";
            this.poisciButton.Size = new System.Drawing.Size(119, 51);
            this.poisciButton.TabIndex = 3;
            this.poisciButton.Text = "Poišči";
            this.poisciButton.UseVisualStyleBackColor = true;
            this.poisciButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Poisci);
            // 
            // podrocjeLabel
            // 
            this.podrocjeLabel.AutoSize = true;
            this.podrocjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podrocjeLabel.Location = new System.Drawing.Point(43, 120);
            this.podrocjeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.podrocjeLabel.Name = "podrocjeLabel";
            this.podrocjeLabel.Size = new System.Drawing.Size(68, 17);
            this.podrocjeLabel.TabIndex = 5;
            this.podrocjeLabel.Text = "Področje:";
            // 
            // podrocjeComboBox
            // 
            this.podrocjeComboBox.FormattingEnabled = true;
            this.podrocjeComboBox.Location = new System.Drawing.Point(115, 119);
            this.podrocjeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.podrocjeComboBox.Name = "podrocjeComboBox";
            this.podrocjeComboBox.Size = new System.Drawing.Size(213, 21);
            this.podrocjeComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nobelovi nagrajenci";
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(772, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.podrocjeComboBox);
            this.Controls.Add(this.podrocjeLabel);
            this.Controls.Add(this.poisciButton);
            this.Controls.Add(this.letoTextBox);
            this.Controls.Add(this.letoLabel);
            this.Controls.Add(this.textBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Okno";
            this.Text = "Nobelovi nagrajenci";
            this.Load += new System.EventHandler(this.OknoNalozi);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label letoLabel;
        private System.Windows.Forms.TextBox letoTextBox;
        private System.Windows.Forms.Button poisciButton;
        private System.Windows.Forms.Label podrocjeLabel;
        private System.Windows.Forms.ComboBox podrocjeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

