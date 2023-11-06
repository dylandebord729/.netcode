namespace SimpleRobot
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
            panMap = new Panel();
            lbDirection = new Label();
            lbOrderedPair = new Label();
            btnNorth = new Button();
            btnSouth = new Button();
            btnEast = new Button();
            btnWest = new Button();
            btnGTen = new Button();
            btnGoOne = new Button();
            btnExit = new Button();
            panMap.SuspendLayout();
            SuspendLayout();
            // 
            // panMap
            // 
            panMap.BorderStyle = BorderStyle.FixedSingle;
            panMap.Controls.Add(lbDirection);
            panMap.Location = new Point(64, 56);
            panMap.Name = "panMap";
            panMap.Size = new Size(232, 241);
            panMap.TabIndex = 0;
            // 
            // lbDirection
            // 
            lbDirection.AutoSize = true;
            lbDirection.Font = new Font("Wingdings", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbDirection.Location = new Point(88, 82);
            lbDirection.Name = "lbDirection";
            lbDirection.Size = new Size(94, 16);
            lbDirection.TabIndex = 0;
            lbDirection.Text = "label1";
            // 
            // lbOrderedPair
            // 
            lbOrderedPair.AutoSize = true;
            lbOrderedPair.Location = new Point(70, 26);
            lbOrderedPair.Name = "lbOrderedPair";
            lbOrderedPair.Size = new Size(53, 20);
            lbOrderedPair.TabIndex = 1;
            lbOrderedPair.Text = "Label1";
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(151, 326);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(31, 29);
            btnNorth.TabIndex = 2;
            btnNorth.Text = "N";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(151, 372);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(31, 29);
            btnSouth.TabIndex = 3;
            btnSouth.Text = "S";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(188, 349);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(31, 29);
            btnEast.TabIndex = 4;
            btnEast.Text = "E";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(114, 349);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(31, 29);
            btnWest.TabIndex = 5;
            btnWest.Text = "W";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // btnGTen
            // 
            btnGTen.Location = new Point(225, 349);
            btnGTen.Name = "btnGTen";
            btnGTen.Size = new Size(60, 29);
            btnGTen.TabIndex = 6;
            btnGTen.Text = "&Go 10";
            btnGTen.UseVisualStyleBackColor = true;
            btnGTen.Click += btnGTen_Click;
            // 
            // btnGoOne
            // 
            btnGoOne.Location = new Point(58, 349);
            btnGoOne.Name = "btnGoOne";
            btnGoOne.Size = new Size(50, 29);
            btnGoOne.TabIndex = 7;
            btnGoOne.Text = "Go 1";
            btnGoOne.UseVisualStyleBackColor = true;
            btnGoOne.Click += btnGoOne_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(225, 420);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(346, 488);
            Controls.Add(btnExit);
            Controls.Add(btnGoOne);
            Controls.Add(btnGTen);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            Controls.Add(lbOrderedPair);
            Controls.Add(panMap);
            Name = "Form1";
            Text = "Simple Robot";
            Load += Form1_Load;
            panMap.ResumeLayout(false);
            panMap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panMap;
        private Label lbOrderedPair;
        private Button btnNorth;
        private Button btnSouth;
        private Button btnEast;
        private Button btnWest;
        private Button btnGTen;
        private Button btnGoOne;
        private Button btnExit;
        private Label lbDirection;
    }
}