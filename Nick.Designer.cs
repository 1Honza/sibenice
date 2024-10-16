namespace sibenice
{
    partial class Nick
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
            this.label1 = new System.Windows.Forms.Label();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.potvrditJmenoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZADEJ SVÉ JMÉNO";
            // 
            // nickTextBox
            // 
            this.nickTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickTextBox.Location = new System.Drawing.Point(72, 77);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(307, 34);
            this.nickTextBox.TabIndex = 1;
            // 
            // potvrditJmenoButton
            // 
            this.potvrditJmenoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potvrditJmenoButton.Location = new System.Drawing.Point(174, 128);
            this.potvrditJmenoButton.Name = "potvrditJmenoButton";
            this.potvrditJmenoButton.Size = new System.Drawing.Size(94, 73);
            this.potvrditJmenoButton.TabIndex = 2;
            this.potvrditJmenoButton.Text = "OK";
            this.potvrditJmenoButton.UseVisualStyleBackColor = true;
            this.potvrditJmenoButton.Click += new System.EventHandler(this.potvrditJmenoButton_Click);
            // 
            // Nick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 213);
            this.Controls.Add(this.potvrditJmenoButton);
            this.Controls.Add(this.nickTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Nick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nickTextBox;
        private Button potvrditJmenoButton;
    }
}