using System.Diagnostics;
using System.Numerics;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace JPWP_Platform_Verbs
{
    public partial class PlatformVerbsForm : Form
    {
        private int counter = 0, timeSec = 15;
        private int score = 1;
        private bool right, left, jump, jumpON, on_platform;
        private int gravity = 20;
        private int force;
        String line, verb;

        Font LargeFont = new Font("Palatino Linotype", 20);

        private string platform_number;


        public PlatformVerbsForm()
        {
            InitializeComponent();

            Timer.Text = timeSec.ToString();
            Player.Location = new Point(600, 240);
            TheWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TheWord.Size = new Size(TheWord.PreferredWidth, TheWord.PreferredHeight);
            TheWord.Font = LargeFont;
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
                on_platform = false;
            }

            if (!on_platform)
            {
                jump = true;
            }
            #endregion

            //displaying verbs
            #region
            try
            {
                StreamReader verbs = new StreamReader(Application.StartupPath + "\\VERBS\\VERBS_CORRECT.txt");
                line = verbs.ReadLine();

                int check = timeSec;

                while (line != null)
                {
                    verb = line;
                    TheWord.Text = verb.Remove(0, 3);
                    line = verbs.ReadLine();
                }

                verbs.Close();
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("file error");
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
                    //System.Diagnostics.Debug.WriteLine(Timer.Text);
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