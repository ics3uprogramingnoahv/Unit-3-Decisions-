
/*
 * Created by:noah Voroney
 * Created on: thusday aprill 4
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program it displays the numbers from 1 - what ever the number you put in
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

namespace DoWhile
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            Double factorialAns;
            Double factorialNum;
            int factorialCounter;

            // clear the box
            this.lstNumbers.Items.Clear();

            //Initalize the answer
            factorialAns = 1;

            // set the use rinput to factorialNum
            factorialNum = Convert.ToDouble(this.txtInput.Text);

            //Set counter to 0
            factorialCounter = 0;

            // loop until the couner is equal
            do
            {
                // add 1 to the counter
                factorialCounter = factorialCounter + 1;

                // add the new number to the list
                lstNumbers.Items.Add(factorialCounter);




            } while (factorialNum >= factorialCounter + 1);

             // dispaly the number in the label

                this.lblAnswer.Text = this.txtInput.Text + "!=" + Convert.ToString(factorialAns);


















        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
