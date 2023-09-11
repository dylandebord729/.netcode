namespace SimpleCalculator
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOperand1 = new TextBox();
            txtOperator = new TextBox();
            txtOperand2 = new TextBox();
            txtResult = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 33);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Operand 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 75);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Operator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 120);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Operand 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 163);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Result:";
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(190, 31);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(125, 27);
            txtOperand1.TabIndex = 4;
            txtOperand1.TextChanged += txtOperand1_TextChanged;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(190, 72);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(34, 27);
            txtOperator.TabIndex = 5;
            txtOperator.TextChanged += txtOperator_TextChanged;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(190, 113);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(125, 27);
            txtOperand2.TabIndex = 6;
            txtOperand2.TextChanged += txtOperand2_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(190, 160);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(91, 213);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(221, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(400, 283);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperator);
            Controls.Add(txtOperand1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOperand1;
        private TextBox txtOperator;
        private TextBox txtOperand2;
        private TextBox txtResult;
        private Button btnCalculate;
        private Button btnExit;
    }
}