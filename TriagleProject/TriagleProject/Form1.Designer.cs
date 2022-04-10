namespace ProjectNetFR
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FirstSide = new System.Windows.Forms.TextBox();
            this.SecondSide = new System.Windows.Forms.TextBox();
            this.ThirdSide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(380, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Очистка полей";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(227, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
            this.button2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.button2_PreviewKeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(24, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Случайные числа";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // FirstSide
            // 
            this.FirstSide.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FirstSide.Location = new System.Drawing.Point(209, 77);
            this.FirstSide.MaxLength = 15;
            this.FirstSide.Name = "FirstSide";
            this.FirstSide.ShortcutsEnabled = false;
            this.FirstSide.Size = new System.Drawing.Size(139, 23);
            this.FirstSide.TabIndex = 3;
            this.FirstSide.TextChanged += new System.EventHandler(this.FirstSide_TextChanged);
            this.FirstSide.Enter += new System.EventHandler(this.FirstSide_Enter);
            this.FirstSide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstSide_KeyPress);
            // 
            // SecondSide
            // 
            this.SecondSide.Location = new System.Drawing.Point(209, 126);
            this.SecondSide.MaxLength = 15;
            this.SecondSide.Name = "SecondSide";
            this.SecondSide.ShortcutsEnabled = false;
            this.SecondSide.Size = new System.Drawing.Size(139, 23);
            this.SecondSide.TabIndex = 4;
            this.SecondSide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondSide_KeyPress);
            // 
            // ThirdSide
            // 
            this.ThirdSide.Location = new System.Drawing.Point(209, 174);
            this.ThirdSide.MaxLength = 15;
            this.ThirdSide.Name = "ThirdSide";
            this.ThirdSide.ShortcutsEnabled = false;
            this.ThirdSide.Size = new System.Drawing.Size(139, 23);
            this.ThirdSide.TabIndex = 5;
            this.ThirdSide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThirdSide_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ВЫЧИСЛЕНИЕ ТИПА ТРЕУГОЛЬНИКА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите первую сторону";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите вторую сторону";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите третью  сторону";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Rage Italic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(130, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "Инструкция по использованию";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Программа для вычисления типа треугольника";
            this.AccessibleName = "Треугольники";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(530, 327);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThirdSide);
            this.Controls.Add(this.SecondSide);
            this.Controls.Add(this.FirstSide);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(546, 366);
            this.MinimumSize = new System.Drawing.Size(546, 366);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Треугольники";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox FirstSide;
        private TextBox SecondSide;
        private TextBox ThirdSide;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button4;
    }
}