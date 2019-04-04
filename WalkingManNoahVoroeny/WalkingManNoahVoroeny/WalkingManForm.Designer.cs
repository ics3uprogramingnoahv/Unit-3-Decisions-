namespace WalkingManNoahVoroeny
{
    partial class frmWalkingMan
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
            this.picWalk = new System.Windows.Forms.PictureBox();
            this.btnWalk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWalk)).BeginInit();
            this.SuspendLayout();
            // 
            // picWalk
            // 
            this.picWalk.Image = global::WalkingManNoahVoroeny.Properties.Resources.walk10;
            this.picWalk.Location = new System.Drawing.Point(36, 53);
            this.picWalk.Name = "picWalk";
            this.picWalk.Size = new System.Drawing.Size(203, 176);
            this.picWalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWalk.TabIndex = 0;
            this.picWalk.TabStop = false;
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(58, 12);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(148, 35);
            this.btnWalk.TabIndex = 1;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.picWalk);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man By Naoh Voroney";
            ((System.ComponentModel.ISupportInitialize)(this.picWalk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWalk;
        private System.Windows.Forms.Button btnWalk;
    }
}

