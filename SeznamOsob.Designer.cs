namespace sibenice
{
    partial class SeznamOsob
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
            this.hraciListBox = new System.Windows.Forms.ListBox();
            this.vycistitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hraciListBox
            // 
            this.hraciListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hraciListBox.FormattingEnabled = true;
            this.hraciListBox.ItemHeight = 25;
            this.hraciListBox.Location = new System.Drawing.Point(12, 73);
            this.hraciListBox.Name = "hraciListBox";
            this.hraciListBox.Size = new System.Drawing.Size(673, 379);
            this.hraciListBox.TabIndex = 0;
            // 
            // vycistitButton
            // 
            this.vycistitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vycistitButton.Location = new System.Drawing.Point(547, 12);
            this.vycistitButton.Name = "vycistitButton";
            this.vycistitButton.Size = new System.Drawing.Size(138, 52);
            this.vycistitButton.TabIndex = 1;
            this.vycistitButton.Text = "VYČISTIT";
            this.vycistitButton.UseVisualStyleBackColor = true;
            this.vycistitButton.Click += new System.EventHandler(this.vycistitButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "NEJLEPŠÍ HRÁČI";
            // 
            // SeznamOsob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vycistitButton);
            this.Controls.Add(this.hraciListBox);
            this.Name = "SeznamOsob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeznamOsob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeznamOsob_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private Button vycistitButton;
        private Label label1;
        public ListBox hraciListBox;
    }
}