namespace Card_Generator
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.genButton = new System.Windows.Forms.Button();
            this.cardNumberTextbox = new System.Windows.Forms.TextBox();
            this.expDatTextBox = new System.Windows.Forms.TextBox();
            this.securityNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.BackColor = System.Drawing.Color.Orange;
            this.genButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.genButton.FlatAppearance.BorderSize = 0;
            this.genButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.ForeColor = System.Drawing.Color.Black;
            this.genButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genButton.Location = new System.Drawing.Point(49, 326);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(264, 80);
            this.genButton.TabIndex = 0;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = false;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // cardNumberTextbox
            // 
            this.cardNumberTextbox.BackColor = System.Drawing.Color.Black;
            this.cardNumberTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.cardNumberTextbox.Location = new System.Drawing.Point(91, 237);
            this.cardNumberTextbox.Name = "cardNumberTextbox";
            this.cardNumberTextbox.ReadOnly = true;
            this.cardNumberTextbox.Size = new System.Drawing.Size(571, 54);
            this.cardNumberTextbox.TabIndex = 1;
            this.cardNumberTextbox.Text = "4917 3000 0000 0008";
            // 
            // expDatTextBox
            // 
            this.expDatTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expDatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expDatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expDatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDatTextBox.ForeColor = System.Drawing.Color.White;
            this.expDatTextBox.Location = new System.Drawing.Point(411, 311);
            this.expDatTextBox.Name = "expDatTextBox";
            this.expDatTextBox.ReadOnly = true;
            this.expDatTextBox.Size = new System.Drawing.Size(152, 46);
            this.expDatTextBox.TabIndex = 2;
            this.expDatTextBox.Text = "XX/XX";
            // 
            // securityNumberTextBox
            // 
            this.securityNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.securityNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.securityNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.securityNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.securityNumberTextBox.Location = new System.Drawing.Point(411, 381);
            this.securityNumberTextBox.Name = "securityNumberTextBox";
            this.securityNumberTextBox.ReadOnly = true;
            this.securityNumberTextBox.Size = new System.Drawing.Size(152, 46);
            this.securityNumberTextBox.TabIndex = 3;
            this.securityNumberTextBox.Text = "XXX";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Card_Generator.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 463);
            this.Controls.Add(this.securityNumberTextBox);
            this.Controls.Add(this.expDatTextBox);
            this.Controls.Add(this.cardNumberTextbox);
            this.Controls.Add(this.genButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Card Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox cardNumberTextbox;
        private System.Windows.Forms.TextBox expDatTextBox;
        private System.Windows.Forms.TextBox securityNumberTextBox;
    }
}

