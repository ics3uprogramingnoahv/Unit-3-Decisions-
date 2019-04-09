namespace RockPaperScissors2NoahVoroney
{
    partial class FrmRockPaperScissors
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
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbComp = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radRockComp = new System.Windows.Forms.RadioButton();
            this.radPaperComp = new System.Windows.Forms.RadioButton();
            this.radScissorsComp = new System.Windows.Forms.RadioButton();
            this.grbUser.SuspendLayout();
            this.grbComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.radScissors);
            this.grbUser.Controls.Add(this.radPaper);
            this.grbUser.Controls.Add(this.radRock);
            this.grbUser.Location = new System.Drawing.Point(12, 12);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(200, 100);
            this.grbUser.TabIndex = 0;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "You";
            this.grbUser.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grbComp
            // 
            this.grbComp.Controls.Add(this.radScissorsComp);
            this.grbComp.Controls.Add(this.radPaperComp);
            this.grbComp.Controls.Add(this.radRockComp);
            this.grbComp.Location = new System.Drawing.Point(12, 130);
            this.grbComp.Name = "grbComp";
            this.grbComp.Size = new System.Drawing.Size(200, 100);
            this.grbComp.TabIndex = 1;
            this.grbComp.TabStop = false;
            this.grbComp.Text = "Computer( Your Oponent)";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(222, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(219, 116);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(20, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 3;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(20, 42);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 4;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(20, 65);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 5;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            // 
            // radRockComp
            // 
            this.radRockComp.AutoSize = true;
            this.radRockComp.Location = new System.Drawing.Point(20, 19);
            this.radRockComp.Name = "radRockComp";
            this.radRockComp.Size = new System.Drawing.Size(51, 17);
            this.radRockComp.TabIndex = 4;
            this.radRockComp.TabStop = true;
            this.radRockComp.Text = "Rock";
            this.radRockComp.UseVisualStyleBackColor = true;
            // 
            // radPaperComp
            // 
            this.radPaperComp.AutoSize = true;
            this.radPaperComp.Location = new System.Drawing.Point(20, 42);
            this.radPaperComp.Name = "radPaperComp";
            this.radPaperComp.Size = new System.Drawing.Size(53, 17);
            this.radPaperComp.TabIndex = 5;
            this.radPaperComp.TabStop = true;
            this.radPaperComp.Text = "Paper";
            this.radPaperComp.UseVisualStyleBackColor = true;
            // 
            // radScissorsComp
            // 
            this.radScissorsComp.AutoSize = true;
            this.radScissorsComp.Location = new System.Drawing.Point(20, 65);
            this.radScissorsComp.Name = "radScissorsComp";
            this.radScissorsComp.Size = new System.Drawing.Size(64, 17);
            this.radScissorsComp.TabIndex = 6;
            this.radScissorsComp.TabStop = true;
            this.radScissorsComp.Text = "Scissors";
            this.radScissorsComp.UseVisualStyleBackColor = true;
            // 
            // FrmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 280);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComp);
            this.Controls.Add(this.grbUser);
            this.Name = "FrmRockPaperScissors";
            this.Text = "ROCK PAPERSCISSORS NOAH VORONEY";
            this.Load += new System.EventHandler(this.FrmRockPaperScissors_Load);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.grbComp.ResumeLayout(false);
            this.grbComp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbComp;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radScissorsComp;
        private System.Windows.Forms.RadioButton radPaperComp;
        private System.Windows.Forms.RadioButton radRockComp;
    }
}

