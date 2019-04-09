/*
 * Created by:Noah Voroney
 * Created on: fri  apr
 * Created for: ICS3U Programming
 * Daily Assignment – idk
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

namespace FactorialWithForLoopNoahV
{
    public partial class frmFactorialWithForLoop : Form
    {
        public frmFactorialWithForLoop()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //local varables declared
            Double sumAns;
            Double sumNum;
            int sumCount;

            // clear list box
            this.lstSumNum.Items.Clear();

            // intialize the final ans to 1
            sumAns = 0;

            //get the user input
            sumNum = Convert.ToDouble(this.nudNum.Value);

            //Start the loop
            for(sumCount = 1; sumCount <= sumNum; sumCount++)
            {
                //add the list
                this.lstSumNum.Items.Add(sumCount);
                //mutiply the input
                sumAns = sumAns + sumCount;


            }

            // display answer
            this.lblAnswer.Text = this.nudNum.Value + " ! + " + Convert.ToString(sumAns);
        }
    }
}
