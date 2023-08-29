namespace ScoreCalculator
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
            txtScore = new TextBox();
            txtScoreTotal = new TextBox();
            txtScoreCount = new TextBox();
            txtAverage = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 80);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Score total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 118);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Score count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 152);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Average:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(212, 40);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 4;
            txtScore.TextChanged += txtScore_TextChanged;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(212, 80);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(125, 27);
            txtScoreTotal.TabIndex = 5;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(212, 118);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(125, 27);
            txtScoreCount.TabIndex = 6;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(212, 152);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(125, 27);
            txtAverage.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(386, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(243, 214);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(386, 214);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(522, 272);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScore);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Score Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtScore;
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtAverage;
        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
    }
}