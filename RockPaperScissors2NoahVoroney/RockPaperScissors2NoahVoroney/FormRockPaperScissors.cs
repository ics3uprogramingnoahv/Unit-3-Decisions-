using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors2NoahVoroney
{
    public partial class FrmRockPaperScissors : Form
    {
        //Declare global variables and consants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;
        int CPUInput;

        public FrmRockPaperScissors()
        {
            InitializeComponent();
            grbComp.Enabled = false;

            // create the random number generator for the computer input
            randomNumberGenerator = new Random();

        }

        private void FrmRockPaperScissors_Load(object sender, EventArgs e)
        {
            CPUInput = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            lblResult.Hide();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Decalre local variables
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            //get the users selection if there is no selection set it to zer0
            if(radRock.Checked = true)
            {
                playerChoice = ROCK;
            }
           else if (radPaper.Checked = true)
            {
                playerChoice = PAPER;
            }
           else if (radScissors.Checked = true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
