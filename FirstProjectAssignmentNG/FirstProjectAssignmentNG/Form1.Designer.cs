namespace FirstProjectAssignmentNG
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
            FontButton1 = new RadioButton();
            FontBox = new GroupBox();
            FontButton4 = new RadioButton();
            FontButton3 = new RadioButton();
            FontButton2 = new RadioButton();
            SizeNumeric = new NumericUpDown();
            SizeBox = new GroupBox();
            TextGroup = new GroupBox();
            EditBox = new TextBox();
            ClipGroup = new GroupBox();
            Clip4 = new Label();
            Clip3 = new Label();
            Clip2 = new Label();
            Clip1 = new Label();
            FontBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SizeNumeric).BeginInit();
            SizeBox.SuspendLayout();
            TextGroup.SuspendLayout();
            ClipGroup.SuspendLayout();
            SuspendLayout();
            // 
            // FontButton1
            // 
            FontButton1.AutoSize = true;
            FontButton1.Checked = true;
            FontButton1.Location = new Point(6, 26);
            FontButton1.Name = "FontButton1";
            FontButton1.Size = new Size(90, 24);
            FontButton1.TabIndex = 1;
            FontButton1.TabStop = true;
            FontButton1.Text = "Segoe UI";
            FontButton1.UseVisualStyleBackColor = true;
            FontButton1.CheckedChanged += FontButton1_CheckedChanged;
            // 
            // FontBox
            // 
            FontBox.Controls.Add(FontButton4);
            FontBox.Controls.Add(FontButton3);
            FontBox.Controls.Add(FontButton2);
            FontBox.Controls.Add(FontButton1);
            FontBox.Location = new Point(21, 29);
            FontBox.Name = "FontBox";
            FontBox.Size = new Size(250, 150);
            FontBox.TabIndex = 2;
            FontBox.TabStop = false;
            FontBox.Text = "Font";
            // 
            // FontButton4
            // 
            FontButton4.AutoSize = true;
            FontButton4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FontButton4.Location = new Point(6, 115);
            FontButton4.Name = "FontButton4";
            FontButton4.Size = new Size(112, 25);
            FontButton4.TabIndex = 4;
            FontButton4.Text = "Montserrat";
            FontButton4.UseVisualStyleBackColor = true;
            FontButton4.CheckedChanged += FontButton4_CheckedChanged;
            // 
            // FontButton3
            // 
            FontButton3.AutoSize = true;
            FontButton3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FontButton3.Location = new Point(6, 85);
            FontButton3.Name = "FontButton3";
            FontButton3.Size = new Size(143, 21);
            FontButton3.TabIndex = 3;
            FontButton3.Text = "Times New Roman";
            FontButton3.UseVisualStyleBackColor = true;
            FontButton3.CheckedChanged += FontButton3_CheckedChanged;
            // 
            // FontButton2
            // 
            FontButton2.AutoSize = true;
            FontButton2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FontButton2.Location = new Point(6, 56);
            FontButton2.Name = "FontButton2";
            FontButton2.Size = new Size(174, 22);
            FontButton2.TabIndex = 2;
            FontButton2.Text = "Showcard Gothic";
            FontButton2.UseVisualStyleBackColor = true;
            FontButton2.CheckedChanged += FontButton2_CheckedChanged;
            // 
            // SizeNumeric
            // 
            SizeNumeric.Location = new Point(6, 26);
            SizeNumeric.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            SizeNumeric.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            SizeNumeric.Name = "SizeNumeric";
            SizeNumeric.Size = new Size(53, 27);
            SizeNumeric.TabIndex = 3;
            SizeNumeric.Value = new decimal(new int[] { 8, 0, 0, 0 });
            SizeNumeric.ValueChanged += SizeNumeric_ValueChanged;
            // 
            // SizeBox
            // 
            SizeBox.Controls.Add(SizeNumeric);
            SizeBox.Location = new Point(21, 185);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(250, 59);
            SizeBox.TabIndex = 4;
            SizeBox.TabStop = false;
            SizeBox.Text = "Size";
            // 
            // TextGroup
            // 
            TextGroup.AutoSize = true;
            TextGroup.Controls.Add(EditBox);
            TextGroup.Location = new Point(277, 29);
            TextGroup.Name = "TextGroup";
            TextGroup.Size = new Size(511, 79);
            TextGroup.TabIndex = 5;
            TextGroup.TabStop = false;
            TextGroup.Text = "Text";
            // 
            // EditBox
            // 
            EditBox.Location = new Point(6, 26);
            EditBox.MaxLength = 12;
            EditBox.Name = "EditBox";
            EditBox.Size = new Size(499, 27);
            EditBox.TabIndex = 0;
            EditBox.KeyDown += EditBox_KeyDown;
            // 
            // ClipGroup
            // 
            ClipGroup.AutoSize = true;
            ClipGroup.Controls.Add(Clip4);
            ClipGroup.Controls.Add(Clip3);
            ClipGroup.Controls.Add(Clip2);
            ClipGroup.Controls.Add(Clip1);
            ClipGroup.Location = new Point(283, 185);
            ClipGroup.Name = "ClipGroup";
            ClipGroup.Size = new Size(499, 253);
            ClipGroup.TabIndex = 6;
            ClipGroup.TabStop = false;
            ClipGroup.Text = "Clipboard";
            // 
            // Clip4
            // 
            Clip4.AutoSize = true;
            Clip4.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clip4.Location = new Point(6, 203);
            Clip4.Name = "Clip4";
            Clip4.Size = new Size(12, 18);
            Clip4.TabIndex = 3;
            Clip4.Text = "-";
            Clip4.DoubleClick += Clip4_DoubleClick;
            // 
            // Clip3
            // 
            Clip3.AutoSize = true;
            Clip3.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clip3.Location = new Point(6, 143);
            Clip3.Name = "Clip3";
            Clip3.Size = new Size(12, 18);
            Clip3.TabIndex = 2;
            Clip3.Text = "-";
            Clip3.DoubleClick += Clip3_DoubleClick;
            // 
            // Clip2
            // 
            Clip2.AutoSize = true;
            Clip2.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clip2.Location = new Point(6, 83);
            Clip2.Name = "Clip2";
            Clip2.Size = new Size(12, 18);
            Clip2.TabIndex = 1;
            Clip2.Text = "-";
            Clip2.DoubleClick += Clip2_DoubleClick;
            // 
            // Clip1
            // 
            Clip1.AutoSize = true;
            Clip1.Font = new Font("Agency FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clip1.Location = new Point(6, 23);
            Clip1.Name = "Clip1";
            Clip1.Size = new Size(12, 18);
            Clip1.TabIndex = 0;
            Clip1.Text = "-";
            Clip1.DoubleClick += Clip1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClipGroup);
            Controls.Add(TextGroup);
            Controls.Add(SizeBox);
            Controls.Add(FontBox);
            Name = "Form1";
            Text = "Form1";
            FontBox.ResumeLayout(false);
            FontBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SizeNumeric).EndInit();
            SizeBox.ResumeLayout(false);
            TextGroup.ResumeLayout(false);
            TextGroup.PerformLayout();
            ClipGroup.ResumeLayout(false);
            ClipGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton FontButton1;
        private GroupBox FontBox;
        private RadioButton FontButton4;
        private RadioButton FontButton3;
        private RadioButton FontButton2;
        private NumericUpDown SizeNumeric;
        private GroupBox SizeBox;
        private GroupBox TextGroup;
        private TextBox EditBox;
        private GroupBox ClipGroup;
        private Label Clip4;
        private Label Clip3;
        private Label Clip2;
        private Label Clip1;
    }
}
