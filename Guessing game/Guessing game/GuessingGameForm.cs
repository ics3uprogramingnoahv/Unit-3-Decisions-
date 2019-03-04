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
            const int NUMBER = 7;
            int guess;

            // get the user imput
            guess = int.Parse(txtImput.Text);

            // tell them if there wrong or not
            if (guess == NUMBER)
            {
                picRightWrong.Image = Properties.Resources.checkmark;
                SoundPlayer splayer2 = new SoundPlayer(@"earrape.wav");
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
