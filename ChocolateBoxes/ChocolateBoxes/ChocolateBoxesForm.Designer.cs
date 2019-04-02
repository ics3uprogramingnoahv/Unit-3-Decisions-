namespace ChocolateBoxes
{
    partial class frmChocolateBoxes
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
            this.components = new System.ComponentModel.Container();
            this.nudBoxes = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblYourReward = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.btnReward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBoxes
            // 
            this.nudBoxes.Location = new System.Drawing.Point(173, 40);
            this.nudBoxes.Name = "nudBoxes";
            this.nudBoxes.Size = new System.Drawing.Size(120, 20);
            this.nudBoxes.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 42);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(155, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "how many boxes have you sold";
            // 
            // lblYourReward
            // 
            this.lblYourReward.AutoSize = true;
            this.lblYourReward.Location = new System.Drawing.Point(12, 182);
            this.lblYourReward.Name = "lblYourReward";
            this.lblYourReward.Size = new System.Drawing.Size(79, 13);
            this.lblYourReward.TabIndex = 3;
            this.lblYourReward.Text = "Your Reward is";
            this.lblYourReward.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Location = new System.Drawing.Point(116, 210);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(35, 13);
            this.lblReward.TabIndex = 4;
            this.lblReward.Text = "label3";
            // 
            // btnReward
            // 
            this.btnReward.Location = new System.Drawing.Point(63, 101);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(75, 23);
            this.btnReward.TabIndex = 5;
            this.btnReward.Text = "Get Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.lblYourReward);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.nudBoxes);
            this.Name = "frmChocolateBoxes";
            this.Text = "chocolate boxe by noah Voroney";
            this.Load += new System.EventHandler(this.ChocolateBoxesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBoxes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblYourReward;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Button btnReward;
    }
}

