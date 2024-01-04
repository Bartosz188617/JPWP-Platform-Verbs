using System.Diagnostics;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace JPWP_Platform_Verbs
{
    public partial class PlatformVerbsForm : Form
    {
        private string[] correct_verbs = new string[]
        {
            "01/BRING",
            "02/SEND",
            "03/SEE",
            "04/GO",
            "05/TAKE",
            "06/GET",
            "07/MAKE",
            "08/KNOW",
            "09/THINK",
            "10/SPEAK",
            "11/COME",
            "12/FIND",
            "13/GIVE",
            "14/TELL",
            "15/SEEK",
            "16/KEEP",
            "17/PUT",
            "18/MAY",
            "19/HOLD",
            "20/LEAVE",
            "21/HEAR",
            "22/STAND",
            "23/FALL",
            "24/LEARN",
            "25/MEAN",
            "26/BUILD",
            "27/BURN",
            "28/BUY",
            "29/TEACH",
            "30/FIGHT",
            "31/THINK",
            "32/LEND",
            "33/LOSE",
            "34/MISTAKE",
            "35/WIN",
            "36/BREAK",
            "37/CHOOSE",
            "38/DRINK",
            "39/FORGET",
            "40/FORGIVE",
            "41/SLEEP",
            "42/SWIM",
            "43/RIDE",
            "44/RUN",
            "45/EAT",
            "46/WEAR",
            "47/DRIVE",
            "48/RING",
            "49/RISE",
            "50/WRITE"
        };

        Random rnd = new Random();

        private int[] used = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int counter = 0, timeSec = 16, index;
        private bool right, left, jump, on_platform;
        private int gravity = 20;
        private int force;


        Font LargeFont = new Font("Palatino Linotype", 20);

        private string platform_number, verb;


        public PlatformVerbsForm()
        {
            InitializeComponent();

            Timer.Text = timeSec.ToString();
            Player.Location = new Point(600, 240);
            TheWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TheWord.Size = new Size(TheWord.PreferredWidth, TheWord.PreferredHeight);
            TheWord.Font = LargeFont;

            index = rnd.Next(0, 49);
            used[0] = index;

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
            //movement behaviour
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

            //collisions with bottom of a game scene
            if (Player.Location.Y >= 650)
            {
                //lose health
                Player.Location = new Point(600, 240);
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
                                Player.Top = x.Top - Player.Width - 1;
                                jump = false;
                                on_platform = true;
                                platform_number = x.Name;                           //checking on which platform the player is standing
                                System.Diagnostics.Debug.WriteLine(platform_number);
                            }
                            
                        } 
                    }
                }
            }

            if ((Player.Location.X > 0 && Player.Location.X < 205) ||     //checking if Player left a platform 
                (Player.Location.X > 405 && Player.Location.X < 515) || 
                (Player.Location.X > 715 && Player.Location.X < 813) || 
                (Player.Location.X > 1013 && Player.Location.X < 1230))
            {
                if (on_platform == true) 
                { 
                    on_platform = false; 
                    platform_number = "none"; 
                    System.Diagnostics.Debug.WriteLine(platform_number);
                }
            }

            if (!on_platform)
            {
                jump = true;
            }
            #endregion

            //displaying verbs
            #region
            if (timeSec == 0)
            {               
                verb = correct_verbs[index];
                TheWord.Text = verb.Remove(0, 3);
                timeSec = 15;
                index = rnd.Next(0, 49);
                for(int k = 0; k < 49; k++) //checking if generated number is new
                {
                    if(used[k] == index)
                    {
                        index = rnd.Next(0, 49);
                        k = 0;
                    }
                }
                used[index] = index;
            }
            #endregion

            //timer
            #region
            if (timeSec != 0)
            {
                if (counter % 30 == 0)
                {
                    timeSec--;

                    if (timeSec < 10)
                    {
                        Timer.Text = "0" + timeSec.ToString();
                    }
                    else
                    {
                        Timer.Text = timeSec.ToString();
                    }
                    //System.Diagnostics.Debug.WriteLine(timeSec);
                    counter = 0;
                }
                counter++;
            }

            #endregion
        }

        private void Platform1_Click(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void TheWord_Click(object sender, EventArgs e)
        {

        }

        private void PlatformVerbsForm_Load(object sender, EventArgs e)
        {

        }
    }
}