﻿/*
 * Created by:Noah
 * Created on: Feb. 7, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 guess numbers
 * This program displays a x or check mark depending on if you guess the number right
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
using System.Media;
namespace Guessing_game
{
    public partial class frmGuessingGame : Form
    {
        public frmGuessingGame()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // declare the constants and variables
            double NUMBER;
            int guess;
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 10;
            Random randomNumberGenerator = new Random();
            NUMBER = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            // get the user imput
            guess = int.Parse(txtImput.Text);

            // tell them if there wrong or not
            if (guess == NUMBER)
            {
                picRightWrong.Image = Properties.Resources.checkmark;
                SoundPlayer splayer2 = new SoundPlayer(@"bell.wav");
                splayer2.Play();
            }


            else
            {
                picRightWrong.Image = Properties.Resources.red_x;
                SoundPlayer splayer = new SoundPlayer(@"earrape.wav");
                splayer.Play();
            }
                
            
        }

        private void txtImput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
