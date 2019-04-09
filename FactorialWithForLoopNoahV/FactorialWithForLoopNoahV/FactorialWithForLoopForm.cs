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
            Double facAns;
            Double facNum;
            int facCount;

            // clear list box
            this.lstFacNum.Items.Clear();

            // intialize the final ans to 1
            facAns = 1;

            //get the user input
            facNum = Convert.ToDouble(this.nudNum.Value);

            //Start the loop
            for(facCount = 1; facCount<= facNum; facCount++)
            {
                //add the list
                this.lstFacNum.Items.Add(facCount);
                //mutiply the input
                facAns = facAns * facCount;


            }

            // display answer
            this.lblAnswer.Text = this.nudNum.Value + " ! + " + Convert.ToString(facAns);
        }
    }
}
