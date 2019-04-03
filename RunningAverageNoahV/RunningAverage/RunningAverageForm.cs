
/*
 * Created by: noah Voroney
 * Created on: apr3 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program that calculates the running average of the numbers you put in
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

namespace RunningAverage
{
    public partial class frmRunningAverage : Form
    {
        // declare variables
        int counter = 0;
        double total = 0;
        double userNumber;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //incriment the counter
            counter++;
                userNumber = Convert.ToDouble(txtInput.Text);

            //if the user enters a number that is 1-100 add it to the total
            if(userNumber >=0)
            {
                total = total + userNumber;
            }

            else if (userNumber == -1)
            {
                MessageBox.Show("Running Average Ended", "Running Average");
                this.btnCalculate.Enabled = false;
                this.txtInput.Visible = false;
            }
            // display results
            lblAverage.Text = Convert.ToString(total / counter);


        }


















        private void label3_Click(object sender, EventArgs e)
        {




        }
    }
}
