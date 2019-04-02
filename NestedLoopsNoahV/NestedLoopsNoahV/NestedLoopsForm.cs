/*
 * Created by: Noah Voroney
 * Created on: tuesday april 2 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
 * This program combines variable to display a given result in the list box
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

namespace NestedLoopsNoahV
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local Vairables
            int capitalLetterCounter;
            int lowerLetterCounter;
            string capitalLetter;
            string lowerLetter;
           
            // clear list box
            this.lstNumbers.Items.Clear();

            // loop through Caracters A to Z
            for(capitalLetterCounter = 65; capitalLetterCounter <=90; capitalLetterCounter++)
            {
              for(lowerLetterCounter = 97; lowerLetterCounter <= 122; lowerLetterCounter++)
                {
                    //convert the upercase to the corosponding lowercase letter
                    capitalLetter = Char.ConvertFromUtf32(capitalLetterCounter);
                    lowerLetter = Char.ConvertFromUtf32(lowerLetterCounter);

                    //display the letters and there corosponding lower case in the list box
                    lstNumbers.Items.Add(capitalLetter + "-->" + lowerLetter);
                  BackColor = Color.Green;

                }

              

            }




        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
