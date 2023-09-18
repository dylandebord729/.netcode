namespace PigLatinTranslator
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
            txtEnglish = new TextBox();
            txtPigLatin = new TextBox();
            lbEnglish = new Label();
            lbPigLatin = new Label();
            btnTranslate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(69, 73);
            txtEnglish.Multiline = true;
            txtEnglish.Name = "txtEnglish";
            txtEnglish.ScrollBars = ScrollBars.Vertical;
            txtEnglish.Size = new Size(447, 145);
            txtEnglish.TabIndex = 0;
            // 
            // txtPigLatin
            // 
            txtPigLatin.Location = new Point(69, 277);
            txtPigLatin.Multiline = true;
            txtPigLatin.Name = "txtPigLatin";
            txtPigLatin.ReadOnly = true;
            txtPigLatin.ScrollBars = ScrollBars.Vertical;
            txtPigLatin.Size = new Size(447, 150);
            txtPigLatin.TabIndex = 1;
            // 
            // lbEnglish
            // 
            lbEnglish.AutoSize = true;
            lbEnglish.Location = new Point(69, 31);
            lbEnglish.Name = "lbEnglish";
            lbEnglish.Size = new Size(164, 20);
            lbEnglish.TabIndex = 2;
            lbEnglish.Text = "Enter English Text Here:";
            // 
            // lbPigLatin
            // 
            lbPigLatin.AutoSize = true;
            lbPigLatin.Location = new Point(69, 234);
            lbPigLatin.Name = "lbPigLatin";
            lbPigLatin.Size = new Size(145, 20);
            lbPigLatin.TabIndex = 3;
            lbPigLatin.Text = "Pig Latin Translation:";
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(69, 464);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(94, 29);
            btnTranslate.TabIndex = 4;
            btnTranslate.Text = "&Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(188, 464);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(422, 464);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnTranslate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(552, 525);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnTranslate);
            Controls.Add(lbPigLatin);
            Controls.Add(lbEnglish);
            Controls.Add(txtPigLatin);
            Controls.Add(txtEnglish);
            Name = "Form1";
            Text = "Pig Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEnglish;
        private TextBox txtPigLatin;
        private Label lbEnglish;
        private Label lbPigLatin;
        private Button btnTranslate;
        private Button btnClear;
        private Button btnExit;
    }
}