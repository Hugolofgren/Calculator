namespace Calculator
{
    partial class CalculatorForm
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
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            Display = new TextBox();
            n0 = new Button();
            Period = new Button();
            Add = new Button();
            Sub = new Button();
            Div = new Button();
            Mul = new Button();
            Equ = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // n1
            // 
            n1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n1.Location = new Point(12, 326);
            n1.Name = "n1";
            n1.Size = new Size(85, 62);
            n1.TabIndex = 0;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += Number_Click;
            // 
            // n2
            // 
            n2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n2.Location = new Point(103, 326);
            n2.Name = "n2";
            n2.Size = new Size(85, 62);
            n2.TabIndex = 1;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += Number_Click;
            // 
            // n3
            // 
            n3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n3.Location = new Point(194, 326);
            n3.Name = "n3";
            n3.Size = new Size(85, 62);
            n3.TabIndex = 2;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += Number_Click;
            // 
            // n4
            // 
            n4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n4.Location = new Point(12, 258);
            n4.Name = "n4";
            n4.Size = new Size(85, 62);
            n4.TabIndex = 3;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += Number_Click;
            // 
            // n5
            // 
            n5.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n5.Location = new Point(103, 258);
            n5.Name = "n5";
            n5.Size = new Size(85, 62);
            n5.TabIndex = 4;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += Number_Click;
            // 
            // n6
            // 
            n6.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n6.Location = new Point(194, 258);
            n6.Name = "n6";
            n6.Size = new Size(85, 62);
            n6.TabIndex = 5;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += Number_Click;
            // 
            // n7
            // 
            n7.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n7.Location = new Point(12, 190);
            n7.Name = "n7";
            n7.Size = new Size(85, 62);
            n7.TabIndex = 6;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += Number_Click;
            // 
            // n8
            // 
            n8.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n8.Location = new Point(103, 190);
            n8.Name = "n8";
            n8.Size = new Size(85, 62);
            n8.TabIndex = 7;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += Number_Click;
            // 
            // n9
            // 
            n9.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n9.Location = new Point(194, 190);
            n9.Name = "n9";
            n9.Size = new Size(85, 62);
            n9.TabIndex = 8;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += Number_Click;
            // 
            // Display
            // 
            Display.BackColor = Color.Gray;
            Display.BorderStyle = BorderStyle.FixedSingle;
            Display.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Display.ForeColor = Color.White;
            Display.Location = new Point(1, 12);
            Display.Name = "Display";
            Display.Size = new Size(369, 87);
            Display.TabIndex = 9;
            Display.Text = "0";
            Display.TextAlign = HorizontalAlignment.Right;
            // 
            // n0
            // 
            n0.BackColor = Color.Transparent;
            n0.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n0.Location = new Point(12, 394);
            n0.Name = "n0";
            n0.Size = new Size(176, 62);
            n0.TabIndex = 10;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += Number_Click;
            // 
            // Period
            // 
            Period.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Period.Location = new Point(194, 394);
            Period.Name = "Period";
            Period.Size = new Size(85, 62);
            Period.TabIndex = 11;
            Period.Text = ".";
            Period.UseVisualStyleBackColor = true;
            Period.Click += Number_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.PaleTurquoise;
            Add.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(285, 326);
            Add.Name = "Add";
            Add.Size = new Size(85, 62);
            Add.TabIndex = 12;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Sub
            // 
            Sub.BackColor = Color.PaleTurquoise;
            Sub.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sub.Location = new Point(285, 258);
            Sub.Name = "Sub";
            Sub.Size = new Size(85, 62);
            Sub.TabIndex = 13;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = false;
            Sub.Click += Sub_Click;
            // 
            // Div
            // 
            Div.BackColor = Color.PaleTurquoise;
            Div.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Div.Location = new Point(285, 121);
            Div.Name = "Div";
            Div.Size = new Size(85, 62);
            Div.TabIndex = 14;
            Div.Text = "/";
            Div.UseVisualStyleBackColor = false;
            Div.Click += Div_Click;
            // 
            // Mul
            // 
            Mul.BackColor = Color.PaleTurquoise;
            Mul.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mul.Location = new Point(285, 190);
            Mul.Name = "Mul";
            Mul.Size = new Size(85, 62);
            Mul.TabIndex = 15;
            Mul.Text = "*";
            Mul.UseVisualStyleBackColor = false;
            Mul.Click += Mul_Click;
            // 
            // Equ
            // 
            Equ.BackColor = Color.PaleTurquoise;
            Equ.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Equ.Location = new Point(285, 394);
            Equ.Name = "Equ";
            Equ.Size = new Size(85, 62);
            Equ.TabIndex = 16;
            Equ.Text = "=";
            Equ.UseVisualStyleBackColor = false;
            Equ.Click += Equ_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(255, 255, 128);
            Clear.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.ForeColor = Color.Black;
            Clear.Location = new Point(12, 121);
            Clear.Name = "Clear";
            Clear.Size = new Size(176, 62);
            Clear.TabIndex = 17;
            Clear.Text = "CLEAR";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(374, 465);
            Controls.Add(Clear);
            Controls.Add(Equ);
            Controls.Add(Mul);
            Controls.Add(Div);
            Controls.Add(Sub);
            Controls.Add(Add);
            Controls.Add(Period);
            Controls.Add(n0);
            Controls.Add(Display);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Name = "CalculatorForm";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private TextBox Display;
        private Button n0;
        private Button Period;
        private Button Add;
        private Button Sub;
        private Button Div;
        private Button Mul;
        private Button Equ;
        private Button Clear;
    }
}
