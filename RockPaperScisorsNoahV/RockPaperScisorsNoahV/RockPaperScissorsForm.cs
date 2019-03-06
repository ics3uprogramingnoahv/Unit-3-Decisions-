using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScisorsNoahV
{
    public partial class frmRockpaperScissors : Form
    {
        //declare global variables
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;
        int ComputerInput;
        public frmRockpaperScissors()
        {
            InitializeComponent();
            // create the random number generator object
            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // decalre local Variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            // get ther users selection, if there is no selection set it to 0
            if (radRockHuman.Checked == true) 
            {

                playerChoice = ROCK;
            }

             else if (radPaperHuman.Checked == true) 
            {

                playerChoice = PAPER;
            }

           else  if (radScissorsHuman.Checked == true) 
            {

                playerChoice = SCISSORS;
            }
            else
           {

                playerChoice = 0;

            }
            // randomly generate a number between 1 and 3, representing Rock, Paper or Scisssors
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set the radio button to for the computer's choice
            if (computerChoice == ROCK)
            {
              else if{ playerChoice == ROCK

                }

                else if{ }

                else { }







            }

        private void frmRockpaperScissors_Load(object sender, EventArgs e)
        {
            ComputerInput = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblWinner.Hide();
        }
    }
}
