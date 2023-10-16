namespace BasicCalculator
{
    partial class Calculator
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
            txtNumber = new TextBox();
            btnBack = new Button();
            btnclear = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btnplusminus = new Button();
            btndec = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            btn3 = new Button();
            btnSubtract = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btndivide1 = new Button();
            btnsqr = new Button();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(49, 33);
            txtNumber.Name = "txtNumber";
            txtNumber.ReadOnly = true;
            txtNumber.Size = new Size(259, 27);
            txtNumber.TabIndex = 0;
            txtNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(48, 87);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(170, 84);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(138, 33);
            btnclear.TabIndex = 2;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(50, 215);
            btn1.Name = "btn1";
            btn1.Size = new Size(31, 32);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(103, 215);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 32);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(50, 267);
            btn0.Name = "btn0";
            btn0.Size = new Size(32, 37);
            btn0.TabIndex = 5;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnplusminus
            // 
            btnplusminus.Location = new Point(103, 271);
            btnplusminus.Name = "btnplusminus";
            btnplusminus.Size = new Size(40, 33);
            btnplusminus.TabIndex = 6;
            btnplusminus.Text = "+/-";
            btnplusminus.UseVisualStyleBackColor = true;
            btnplusminus.Click += btnplusminus_Click;
            // 
            // btndec
            // 
            btndec.Location = new Point(159, 276);
            btndec.Name = "btndec";
            btndec.Size = new Size(31, 28);
            btndec.TabIndex = 7;
            btndec.Text = ".";
            btndec.UseVisualStyleBackColor = true;
            btndec.Click += btndec_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(208, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(259, 229);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(36, 75);
            btnEqual.TabIndex = 9;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(159, 218);
            btn3.Name = "btn3";
            btn3.Size = new Size(31, 29);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(208, 218);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(29, 29);
            btnSubtract.TabIndex = 11;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(50, 171);
            btn4.Name = "btn4";
            btn4.Size = new Size(31, 28);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(49, 131);
            btn7.Name = "btn7";
            btn7.Size = new Size(31, 34);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(103, 170);
            btn5.Name = "btn5";
            btn5.Size = new Size(39, 29);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(103, 134);
            btn8.Name = "btn8";
            btn8.Size = new Size(39, 29);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(163, 175);
            btn6.Name = "btn6";
            btn6.Size = new Size(27, 29);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(159, 134);
            btn9.Name = "btn9";
            btn9.Size = new Size(31, 29);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(211, 177);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(26, 29);
            btnMultiply.TabIndex = 18;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(215, 134);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(22, 29);
            btnDivide.TabIndex = 19;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btndivide1
            // 
            btndivide1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btndivide1.Location = new Point(259, 177);
            btndivide1.Name = "btndivide1";
            btndivide1.Size = new Size(36, 29);
            btndivide1.TabIndex = 20;
            btndivide1.Text = "1/x";
            btndivide1.UseVisualStyleBackColor = true;
            btndivide1.Click += btndivide1_Click;
            // 
            // btnsqr
            // 
            btnsqr.Location = new Point(255, 139);
            btnsqr.Name = "btnsqr";
            btnsqr.Size = new Size(40, 29);
            btnsqr.TabIndex = 21;
            btnsqr.Text = "sqr";
            btnsqr.UseVisualStyleBackColor = true;
            btnsqr.Click += btnsqr_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 325);
            Controls.Add(btnsqr);
            Controls.Add(btndivide1);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btndec);
            Controls.Add(btnplusminus);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnclear);
            Controls.Add(btnBack);
            Controls.Add(txtNumber);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnBack;
        private Button btnclear;
        private Button btn1;
        private Button btn2;
        private Button btn0;
        private Button btnplusminus;
        private Button btndec;
        private Button btnAdd;
        private Button btnEqual;
        private Button btn3;
        private Button btnSubtract;
        private Button btn4;
        private Button btn7;
        private Button btn5;
        private Button btn8;
        private Button btn6;
        private Button btn9;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btndivide1;
        private Button btnsqr;
    }
}