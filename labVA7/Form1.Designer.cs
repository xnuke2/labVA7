namespace labVA7
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
            button1 = new Button();
            label1 = new Label();
            labelMidleRectangle = new Label();
            label3 = new Label();
            label4 = new Label();
            labelLeftRegtangle = new Label();
            label6 = new Label();
            labelRightRectangle = new Label();
            label2 = new Label();
            labelTrapezoid = new Label();
            label5 = new Label();
            labelSimpson = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            labelErrorMidleRectangl = new Label();
            labelErrorLeftRectangl = new Label();
            labelErrorRightRectangl = new Label();
            labelErrorTrapezoid = new Label();
            labelErrorSimpson = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(159, 12);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 0;
            button1.Text = "Вычеслить значение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(286, 15);
            label1.TabIndex = 1;
            label1.Text = "Значение интеграла о формуле прямоугольников";
            // 
            // labelMidleRectangle
            // 
            labelMidleRectangle.AutoSize = true;
            labelMidleRectangle.Location = new Point(104, 95);
            labelMidleRectangle.Name = "labelMidleRectangle";
            labelMidleRectangle.Size = new Size(38, 15);
            labelMidleRectangle.TabIndex = 2;
            labelMidleRectangle.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 95);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Средних";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 122);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Левых";
            // 
            // labelLeftRegtangle
            // 
            labelLeftRegtangle.AutoSize = true;
            labelLeftRegtangle.Location = new Point(104, 122);
            labelLeftRegtangle.Name = "labelLeftRegtangle";
            labelLeftRegtangle.Size = new Size(38, 15);
            labelLeftRegtangle.TabIndex = 5;
            labelLeftRegtangle.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 147);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 6;
            label6.Text = "Правых";
            // 
            // labelRightRectangle
            // 
            labelRightRectangle.AutoSize = true;
            labelRightRectangle.Location = new Point(104, 147);
            labelRightRectangle.Name = "labelRightRectangle";
            labelRightRectangle.Size = new Size(38, 15);
            labelRightRectangle.TabIndex = 7;
            labelRightRectangle.Text = "label7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(245, 15);
            label2.TabIndex = 8;
            label2.Text = "Значение интеграла по формуле трапеций";
            // 
            // labelTrapezoid
            // 
            labelTrapezoid.AutoSize = true;
            labelTrapezoid.Location = new Point(35, 229);
            labelTrapezoid.Name = "labelTrapezoid";
            labelTrapezoid.Size = new Size(38, 15);
            labelTrapezoid.TabIndex = 9;
            labelTrapezoid.Text = "label7";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 265);
            label5.Name = "label5";
            label5.Size = new Size(250, 15);
            label5.TabIndex = 10;
            label5.Text = "Значение интеграла по формуле Симпсона";
            // 
            // labelSimpson
            // 
            labelSimpson.AutoSize = true;
            labelSimpson.Location = new Point(35, 297);
            labelSimpson.Name = "labelSimpson";
            labelSimpson.Size = new Size(38, 15);
            labelSimpson.TabIndex = 11;
            labelSimpson.Text = "label7";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 7;
            numericUpDown1.Location = new Point(68, 20);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(87, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 196608 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 23);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Точность";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 65);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 14;
            label8.Text = "Оценка погрешности";
            // 
            // labelErrorMidleRectangl
            // 
            labelErrorMidleRectangl.AutoSize = true;
            labelErrorMidleRectangl.Location = new Point(336, 95);
            labelErrorMidleRectangl.Name = "labelErrorMidleRectangl";
            labelErrorMidleRectangl.Size = new Size(38, 15);
            labelErrorMidleRectangl.TabIndex = 15;
            labelErrorMidleRectangl.Text = "label2";
            // 
            // labelErrorLeftRectangl
            // 
            labelErrorLeftRectangl.AutoSize = true;
            labelErrorLeftRectangl.Location = new Point(336, 122);
            labelErrorLeftRectangl.Name = "labelErrorLeftRectangl";
            labelErrorLeftRectangl.Size = new Size(38, 15);
            labelErrorLeftRectangl.TabIndex = 16;
            labelErrorLeftRectangl.Text = "label2";
            // 
            // labelErrorRightRectangl
            // 
            labelErrorRightRectangl.AutoSize = true;
            labelErrorRightRectangl.Location = new Point(336, 147);
            labelErrorRightRectangl.Name = "labelErrorRightRectangl";
            labelErrorRightRectangl.Size = new Size(38, 15);
            labelErrorRightRectangl.TabIndex = 17;
            labelErrorRightRectangl.Text = "label2";
            // 
            // labelErrorTrapezoid
            // 
            labelErrorTrapezoid.AutoSize = true;
            labelErrorTrapezoid.Location = new Point(336, 229);
            labelErrorTrapezoid.Name = "labelErrorTrapezoid";
            labelErrorTrapezoid.Size = new Size(38, 15);
            labelErrorTrapezoid.TabIndex = 18;
            labelErrorTrapezoid.Text = "label2";
            // 
            // labelErrorSimpson
            // 
            labelErrorSimpson.AutoSize = true;
            labelErrorSimpson.Location = new Point(336, 297);
            labelErrorSimpson.Name = "labelErrorSimpson";
            labelErrorSimpson.Size = new Size(38, 15);
            labelErrorSimpson.TabIndex = 19;
            labelErrorSimpson.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 323);
            Controls.Add(labelErrorSimpson);
            Controls.Add(labelErrorTrapezoid);
            Controls.Add(labelErrorRightRectangl);
            Controls.Add(labelErrorLeftRectangl);
            Controls.Add(labelErrorMidleRectangl);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(labelSimpson);
            Controls.Add(label5);
            Controls.Add(labelTrapezoid);
            Controls.Add(label2);
            Controls.Add(labelRightRectangle);
            Controls.Add(label6);
            Controls.Add(labelLeftRegtangle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelMidleRectangle);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "интегральный калькулятор";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label labelMidleRectangle;
        private Label label3;
        private Label label4;
        private Label labelLeftRegtangle;
        private Label label6;
        private Label labelRightRectangle;
        private Label label2;
        private Label labelTrapezoid;
        private Label label5;
        private Label labelSimpson;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label8;
        private Label labelErrorMidleRectangl;
        private Label labelErrorLeftRectangl;
        private Label labelErrorRightRectangl;
        private Label labelErrorTrapezoid;
        private Label labelErrorSimpson;
    }
}
