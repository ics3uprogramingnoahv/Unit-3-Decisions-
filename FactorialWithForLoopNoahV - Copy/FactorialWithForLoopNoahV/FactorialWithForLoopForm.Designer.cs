namespace FactorialWithForLoopNoahV
{
    partial class frmFactorialWithForLoop
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
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstSumNum = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNum
            // 
            this.nudNum.Location = new System.Drawing.Point(82, 50);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(120, 20);
            this.nudNum.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(103, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstSumNum
            // 
            this.lstSumNum.FormattingEnabled = true;
            this.lstSumNum.Location = new System.Drawing.Point(82, 91);
            this.lstSumNum.Name = "lstSumNum";
            this.lstSumNum.Size = new System.Drawing.Size(120, 95);
            this.lstSumNum.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(79, 222);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "label1";
            // 
            // frmFactorialWithForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstSumNum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudNum);
            this.Name = "frmFactorialWithForLoop";
            this.Text = "Factorial with For Loop by Noah Voroney";
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstSumNum;
        private System.Windows.Forms.Label lblAnswer;
    }
}

