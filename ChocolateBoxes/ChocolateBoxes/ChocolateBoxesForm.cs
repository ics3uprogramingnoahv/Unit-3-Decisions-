
/*
 * Created by: Noah Voroney
 * Created on: 01-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - it tll the user what they get for the amount of boxes they sold
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

namespace ChocolateBoxes
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
        }

        private void ChocolateBoxesForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            // set up the chocolate boxes imput
            int chocolateBoxes;
            chocolateBoxes = Convert.ToInt32(nudBoxes.Value);

            if(chocolateBoxes > 20)
            {

                this.lblReward.Text = " A prize";
            }
            else 
            {
              if(chocolateBoxes < 10)
                {
                    this.lblReward.Text = " An Honourable Mention!";
                }
                else
                {
                    this.lblReward.Text = " A small prize";
                }

           
            }



        }
    }
}
