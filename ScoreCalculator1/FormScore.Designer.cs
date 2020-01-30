namespace ScoreCalculator1
{
    partial class FormScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(161, 45);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(48, 22);
            this.txtScore.TabIndex = 0;
            this.txtScore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(161, 90);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(48, 22);
            this.txtScoreTotal.TabIndex = 5;
            this.txtScoreTotal.TabStop = false;
            this.txtScoreTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(161, 133);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(48, 22);
            this.txtScoreCount.TabIndex = 6;
            this.txtScoreCount.TabStop = false;
            this.txtScoreCount.Text = "\r\n";
            this.txtScoreCount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(161, 182);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(48, 22);
            this.txtAverage.TabIndex = 7;
            this.txtAverage.TabStop = false;
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(255, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearScore
            // 
            this.btnClearScore.Location = new System.Drawing.Point(97, 251);
            this.btnClearScore.Name = "btnClearScore";
            this.btnClearScore.Size = new System.Drawing.Size(101, 36);
            this.btnClearScore.TabIndex = 2;
            this.btnClearScore.Text = "Clear Scores";
            this.btnClearScore.UseVisualStyleBackColor = true;
            this.btnClearScore.Click += new System.EventHandler(this.btnClearScore_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormScore
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormScore";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearScore;
        private System.Windows.Forms.Button btnExit;
    }
}

