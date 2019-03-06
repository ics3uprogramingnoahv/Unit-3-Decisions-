namespace RockPaperScisorsNoahV
{
    partial class frmRockpaperScissors
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
            this.grbHuman = new System.Windows.Forms.GroupBox();
            this.radScissorsHuman = new System.Windows.Forms.RadioButton();
            this.radPaperHuman = new System.Windows.Forms.RadioButton();
            this.radRockHuman = new System.Windows.Forms.RadioButton();
            this.grbComputer = new System.Windows.Forms.GroupBox();
            this.radScissorsComputer = new System.Windows.Forms.RadioButton();
            this.radPaperComputer = new System.Windows.Forms.RadioButton();
            this.radRockComputer = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.grbHuman.SuspendLayout();
            this.grbComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHuman
            // 
            this.grbHuman.Controls.Add(this.radScissorsHuman);
            this.grbHuman.Controls.Add(this.radPaperHuman);
            this.grbHuman.Controls.Add(this.radRockHuman);
            this.grbHuman.Location = new System.Drawing.Point(27, 29);
            this.grbHuman.Name = "grbHuman";
            this.grbHuman.Size = new System.Drawing.Size(200, 123);
            this.grbHuman.TabIndex = 0;
            this.grbHuman.TabStop = false;
            this.grbHuman.Text = "Human";
            // 
            // radScissorsHuman
            // 
            this.radScissorsHuman.AutoSize = true;
            this.radScissorsHuman.Location = new System.Drawing.Point(23, 83);
            this.radScissorsHuman.Name = "radScissorsHuman";
            this.radScissorsHuman.Size = new System.Drawing.Size(64, 17);
            this.radScissorsHuman.TabIndex = 2;
            this.radScissorsHuman.TabStop = true;
            this.radScissorsHuman.Text = "Scissors";
            this.radScissorsHuman.UseVisualStyleBackColor = true;
            // 
            // radPaperHuman
            // 
            this.radPaperHuman.AutoSize = true;
            this.radPaperHuman.Location = new System.Drawing.Point(23, 60);
            this.radPaperHuman.Name = "radPaperHuman";
            this.radPaperHuman.Size = new System.Drawing.Size(53, 17);
            this.radPaperHuman.TabIndex = 1;
            this.radPaperHuman.TabStop = true;
            this.radPaperHuman.Text = "Paper";
            this.radPaperHuman.UseVisualStyleBackColor = true;
            // 
            // radRockHuman
            // 
            this.radRockHuman.AutoSize = true;
            this.radRockHuman.Location = new System.Drawing.Point(23, 37);
            this.radRockHuman.Name = "radRockHuman";
            this.radRockHuman.Size = new System.Drawing.Size(51, 17);
            this.radRockHuman.TabIndex = 0;
            this.radRockHuman.TabStop = true;
            this.radRockHuman.Text = "Rock";
            this.radRockHuman.UseVisualStyleBackColor = true;
            // 
            // grbComputer
            // 
            this.grbComputer.Controls.Add(this.radScissorsComputer);
            this.grbComputer.Controls.Add(this.radPaperComputer);
            this.grbComputer.Controls.Add(this.radRockComputer);
            this.grbComputer.Location = new System.Drawing.Point(27, 189);
            this.grbComputer.Name = "grbComputer";
            this.grbComputer.Size = new System.Drawing.Size(200, 123);
            this.grbComputer.TabIndex = 0;
            this.grbComputer.TabStop = false;
            this.grbComputer.Text = "Computer";
            // 
            // radScissorsComputer
            // 
            this.radScissorsComputer.AutoSize = true;
            this.radScissorsComputer.Location = new System.Drawing.Point(23, 77);
            this.radScissorsComputer.Name = "radScissorsComputer";
            this.radScissorsComputer.Size = new System.Drawing.Size(64, 17);
            this.radScissorsComputer.TabIndex = 3;
            this.radScissorsComputer.TabStop = true;
            this.radScissorsComputer.Text = "Scissors";
            this.radScissorsComputer.UseVisualStyleBackColor = true;
            // 
            // radPaperComputer
            // 
            this.radPaperComputer.AutoSize = true;
            this.radPaperComputer.Location = new System.Drawing.Point(23, 54);
            this.radPaperComputer.Name = "radPaperComputer";
            this.radPaperComputer.Size = new System.Drawing.Size(53, 17);
            this.radPaperComputer.TabIndex = 4;
            this.radPaperComputer.TabStop = true;
            this.radPaperComputer.Text = "Paper";
            this.radPaperComputer.UseVisualStyleBackColor = true;
            // 
            // radRockComputer
            // 
            this.radRockComputer.AutoSize = true;
            this.radRockComputer.Location = new System.Drawing.Point(23, 31);
            this.radRockComputer.Name = "radRockComputer";
            this.radRockComputer.Size = new System.Drawing.Size(51, 17);
            this.radRockComputer.TabIndex = 5;
            this.radRockComputer.TabStop = true;
            this.radRockComputer.Text = "Rock";
            this.radRockComputer.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(282, 58);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 71);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(293, 189);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(127, 13);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "winer winer chicken diner";
            // 
            // frmRockpaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 362);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputer);
            this.Controls.Add(this.grbHuman);
            this.Name = "frmRockpaperScissors";
            this.Text = "RockPaperScissors";
            this.Load += new System.EventHandler(this.frmRockpaperScissors_Load);
            this.grbHuman.ResumeLayout(false);
            this.grbHuman.PerformLayout();
            this.grbComputer.ResumeLayout(false);
            this.grbComputer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHuman;
        private System.Windows.Forms.RadioButton radScissorsHuman;
        private System.Windows.Forms.RadioButton radPaperHuman;
        private System.Windows.Forms.RadioButton radRockHuman;
        private System.Windows.Forms.GroupBox grbComputer;
        private System.Windows.Forms.RadioButton radScissorsComputer;
        private System.Windows.Forms.RadioButton radPaperComputer;
        private System.Windows.Forms.RadioButton radRockComputer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblWinner;
    }
}

