using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;

namespace JPWP_Platform_Verbs
{
    public partial class PlatformVerbsForm : Form
    {
        private bool right, left, jump, jumpON;
        private int gravity = 25;
        private int force;

        public PlatformVerbsForm()
        {
            InitializeComponent();
            //Player.Location = new Point(615, 480);
            //Platform1.Location = new Point(490, 670);
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            //movement_behaviour
            #region
            if (e.KeyCode == Keys.D) { right = true; }

            if (e.KeyCode == Keys.A) { left = true; }

            if (!jump)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = gravity;
                }
            }
            #endregion
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            //movement_behaviour
            #region
            if (e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            #endregion
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //movement_behaviour
            #region
            if (right) 
            {
                Player.Left += 10;            
            }

            if (left) 
            {
                Player.Left -= 10;            
            }

            if (jump)
            {          
                Player.Top -= force;
                if (force > -10)
                {
                    force -= 1;
                }
                else
                {
                    force = -10;
                }
                
                System.Diagnostics.Debug.WriteLine(force);
            }

            if (Player.Top + Player.Height >= GameScene.Height) //making sure the Player won't fall of the GameScene after jump
            {
                Player.Top = GameScene.Height - Player.Height;
                jump = false;
            }
            else
            {

                Player.Top += 5;
            }
            #endregion

            //collisions
            #region
            //collisions with sides of a panel
            if (Player.Left <= 0)
            {
                Player.Left = 0;
            }
            if (Player.Left + Player.Width >= GameScene.Width)
            {
                Player.Left = GameScene.Width - Player.Width;
            }

            //collisions with platforms
            foreach (Control x in GameScene.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Plat")
                    {   
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (force <= 0 && Player.Bottom <= x.Bottom)
                            {
                                Player.Top = x.Top - Player.Width + 1;
                                jump = false;
                            }
                        }                       
                    }
                }
            }


   






            #endregion

        }

        private void Platform1_Click(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }
    }
}