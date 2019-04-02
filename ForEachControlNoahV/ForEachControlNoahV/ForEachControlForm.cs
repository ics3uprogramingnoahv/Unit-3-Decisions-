/*
 * Created by: Noah Voroney
 * Created on: tue apr 2 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes the colur of the objects when interacted with
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachControlNoahV
{
    public partial class frmForEachControl : Form
    {
        public frmForEachControl()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // change the colur of the the objects to green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
            }

        }

        private void lblGov_Click(object sender, EventArgs e)
        {
            // change the colur of the the objects to green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Purple;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Green;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // change the colur of the the objects to green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Green;
                }
                if (aControlObject.GetType() == typeof(PictureBox))
                {
                    aControlObject.BackColor = Color.Yellow;
                }
            }
        }
    }
}
