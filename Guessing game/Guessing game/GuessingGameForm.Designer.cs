namespace Guessing_game
{
    partial class frmGuessingGame
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
            this.txtImput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.picRightWrong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImput
            // 
            this.txtImput.Location = new System.Drawing.Point(319, 94);
            this.txtImput.Name = "txtImput";
            this.txtImput.Size = new System.Drawing.Size(100, 20);
            this.txtImput.TabIndex = 0;
            this.txtImput.TextChanged += new System.EventHandler(this.txtImput_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(298, 120);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(170, 97);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(120, 13);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Guess the number(1-10)";
            // 
            // picRightWrong
            // 
            this.picRightWrong.Image = global::Guessing_game.Properties.Resources.red_x;
            this.picRightWrong.Location = new System.Drawing.Point(12, 120);
            this.picRightWrong.Name = "picRightWrong";
            this.picRightWrong.Size = new System.Drawing.Size(163, 120);
            this.picRightWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightWrong.TabIndex = 4;
            this.picRightWrong.TabStop = false;
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.picRightWrong);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtImput);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing game";
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox picRightWrong;
    }
}

