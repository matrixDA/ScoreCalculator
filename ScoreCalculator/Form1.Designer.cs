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
            btnClear = new Button();
            btnExit = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 55);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Score: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 181);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 1;
            label2.Text = "Score Count:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 116);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 2;
            label3.Text = "Score Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 247);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 3;
            label4.Text = "Average:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(253, 55);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(96, 39);
            txtScore.TabIndex = 1;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(253, 116);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(96, 39);
            txtScoreTotal.TabIndex = 5;
            txtScoreTotal.TabStop = false;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(253, 181);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(96, 39);
            txtScoreCount.TabIndex = 6;
            txtScoreCount.TabStop = false;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(253, 247);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(96, 39);
            txtAverage.TabIndex = 7;
            txtAverage.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(199, 320);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(385, 320);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 46);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(385, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(576, 416);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScore);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Calculator";
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
        private Button btnClear;
        private Button btnExit;
        private Button btnAdd;
    }
}