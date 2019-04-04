
/*
 * Created by: noah Voroney
 * Created on: thur 4 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 -walking man it displays to images in a sequence to make it look like he is walikng
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
//Sleep library
using System.Threading;
namespace WalkingManNoahVoroeny
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {

            //local variables / constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //Continue the loop as long as the counter has not reach the max number of frames
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picWalk.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picWalk.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    this.picWalk.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picWalk.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picWalk.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picWalk.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picWalk.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picWalk.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picWalk.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    this.picWalk.Image = Properties.Resources.walk10;
                }

                //Add 1 to the counter
                pictureFrameCounter = pictureFrameCounter + 1;

                //Refresh the screen
                this.Refresh();

                //pause the loop for 100 milliseconds
                Thread.Sleep(100);
            }


















        }
    }
}
