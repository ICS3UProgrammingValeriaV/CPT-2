using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ArcadeValeriaV
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            tmrBurn.Start();
            

               

        }
        private void picLogo_Click(object sender, EventArgs e)
        {


        }

        private void tmrBurn_Tick(object sender, EventArgs e)
        {
            const int MAX_FRAMES = 9;
            
            for (int counter = 1; counter <= MAX_FRAMES; counter ++)
            {
                if (counter == 1)
                {
                    picLogo.Image = Properties.Resources.fireText2;
                }
                else if (counter == 2)
                {
                    picLogo.Image = Properties.Resources.fireText3;
                }
                else if (counter == 3)
                {
                    picLogo.Image = Properties.Resources.fireText4;
                }
                else if (counter == 4)
                {
                    picLogo.Image = Properties.Resources.fireText5;
                }
                else if (counter == 5)
                {
                    picLogo.Image = Properties.Resources.fireText6;
                }
                else if (counter == 6)
                {
                    picLogo.Image = Properties.Resources.fireText7;
                }
                else if (counter == 8)
                {
                    picLogo.Image = Properties.Resources.fireText9;
                }
                else if (counter == 9)
                {
                    picLogo.Image = Properties.Resources.fireText10;
                    tmrBurn.Stop();
                }
                //refresh the form
                this.Refresh();
                //pause the loop for 100 miliseconds
                Thread.Sleep(5);

            }
        }
    }   
}
