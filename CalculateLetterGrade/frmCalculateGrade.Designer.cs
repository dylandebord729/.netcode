﻿namespace CalculateLetterGrade
{
    partial class frmCalculateGrade
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
            label2 = new Label();
            txtNumberGrade = new TextBox();
            txtLetterGrade = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 67);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "&Number grade:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 99);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Letter Grade:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.Location = new Point(182, 69);
            txtNumberGrade.Name = "txtNumberGrade";
            txtNumberGrade.Size = new Size(125, 27);
            txtNumberGrade.TabIndex = 1;
            txtNumberGrade.TextChanged += txtNumberGrade_TextChanged;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.Location = new Point(183, 104);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.ReadOnly = true;
            txtLetterGrade.Size = new Size(125, 27);
            txtLetterGrade.TabIndex = 3;
            txtLetterGrade.TabStop = false;
            txtLetterGrade.TextChanged += txtLetterGrade_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(67, 159);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(213, 159);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmCalculateGrade
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(474, 304);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtLetterGrade);
            Controls.Add(txtNumberGrade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculateGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumberGrade;
        private TextBox txtLetterGrade;
        private Button btnCalculate;
        private Button btnExit;
    }
}