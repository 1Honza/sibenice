namespace sibenice
{
    partial class Form1
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
            label1 = new Label();
            tipTextBox = new TextBox();
            labelHledaneSlovo = new Label();
            tipniButton = new Button();
            resetButton = new Button();
            label3 = new Label();
            labelPocetChyb = new Label();
            pictureBoxSibenice = new PictureBox();
            nejlepsiButton1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSibenice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, -4);
            label1.Name = "label1";
            label1.Size = new Size(59, 37);
            label1.TabIndex = 0;
            label1.Text = "TIP:";
            // 
            // tipTextBox
            // 
            tipTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tipTextBox.Location = new Point(74, 36);
            tipTextBox.MaxLength = 1;
            tipTextBox.Name = "tipTextBox";
            tipTextBox.Size = new Size(50, 34);
            tipTextBox.TabIndex = 1;
            tipTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // labelHledaneSlovo
            // 
            labelHledaneSlovo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelHledaneSlovo.Location = new Point(12, 359);
            labelHledaneSlovo.Name = "labelHledaneSlovo";
            labelHledaneSlovo.Size = new Size(235, 32);
            labelHledaneSlovo.TabIndex = 2;
            labelHledaneSlovo.Text = "Hledane slovo";
            labelHledaneSlovo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tipniButton
            // 
            tipniButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tipniButton.Location = new Point(174, 12);
            tipniButton.Name = "tipniButton";
            tipniButton.Size = new Size(98, 58);
            tipniButton.TabIndex = 3;
            tipniButton.Text = "TIPNI";
            tipniButton.UseVisualStyleBackColor = true;
            tipniButton.Click += tipniButton_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(12, 394);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(101, 47);
            resetButton.TabIndex = 4;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 76);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 5;
            // 
            // labelPocetChyb
            // 
            labelPocetChyb.AutoSize = true;
            labelPocetChyb.Location = new Point(134, 82);
            labelPocetChyb.Name = "labelPocetChyb";
            labelPocetChyb.Size = new Size(13, 15);
            labelPocetChyb.TabIndex = 6;
            labelPocetChyb.Text = "0";
            // 
            // pictureBoxSibenice
            // 
            pictureBoxSibenice.Location = new Point(23, 117);
            pictureBoxSibenice.Name = "pictureBoxSibenice";
            pictureBoxSibenice.Size = new Size(209, 239);
            pictureBoxSibenice.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSibenice.TabIndex = 7;
            pictureBoxSibenice.TabStop = false;
            // 
            // nejlepsiButton1
            // 
            nejlepsiButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nejlepsiButton1.Location = new Point(162, 394);
            nejlepsiButton1.Name = "nejlepsiButton1";
            nejlepsiButton1.Size = new Size(131, 47);
            nejlepsiButton1.TabIndex = 8;
            nejlepsiButton1.Text = "Nejlepší hráči";
            nejlepsiButton1.UseVisualStyleBackColor = true;
            nejlepsiButton1.Click += nejlepsiButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 82);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 9;
            label5.Text = "Počet chyb: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 453);
            Controls.Add(label5);
            Controls.Add(nejlepsiButton1);
            Controls.Add(pictureBoxSibenice);
            Controls.Add(labelPocetChyb);
            Controls.Add(label3);
            Controls.Add(resetButton);
            Controls.Add(tipniButton);
            Controls.Add(labelHledaneSlovo);
            Controls.Add(tipTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sibenice";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSibenice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelHledaneSlovo;
        private Button tipniButton;
        private Button resetButton;
        public TextBox tipTextBox;
        private Label label3;
        private Label labelPocetChyb;
        private PictureBox pictureBoxSibenice;
        private Button nejlepsiButton1;
        private Label label5;
    }
}