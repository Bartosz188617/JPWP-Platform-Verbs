using System.Diagnostics;
using System.Numerics;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace JPWP_Platform_Verbs
{
    public partial class PlatformVerbsForm : Form
    {
        private string[] verbs = new string[]
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
        private string[] answers = new string[]
        {
            "01/BROUGHT",
            "01/BRINGED",
            "01/BROUGH",
            "01/BRING",
            "02/SENT",
            "02/SENDING",
            "02/SEN",
            "02/SEND",
            "03/SAW",
            "03/SEED",
            "03/SEE",
            "03/SEN",
            "04/WENT",
            "04/GOT",
            "04/GO",
            "04/GONED",
            "05/TOOK",
            "05/TOOKED",
            "05/TAKE",
            "05/TAKENED",
            "06/GOT",
            "06/GETED",
            "06/GET",
            "06/GOTTEN",
            "07/MADE",
            "07/MAKED",
            "07/MAKE",
            "07/MAKEN",
            "08/KNEW",
            "08/KNOWED",
            "08/KNOW",
            "08/KNOWING",
            "09/THOUGHT",
            "09/THINKED",
            "09/THINK",
            "09/THOUGHTEN",
            "10/SPOKE",
            "10/SPEAKED",
            "10/SPEAK",
            "10/SPOKENED",
            "11/CAME",
            "11/COME",
            "11/COME",
            "11/COMED",
            "12/FOUND",
            "12/FINDED",
            "12/FOUNDEN",
            "12/FIND",
            "13/GAVE",
            "13/GIVED",
            "13/GIVEN",
            "13/GIVE",
            "14/TOLD",
            "14/TELED",
            "14/TOLDEN",
            "14/TELL",
            "15/SOUGHT",
            "15/SEEK",
            "15/SEEKED",
            "15/SOUGHTEN",
            "16/KEPT",
            "16/KEEP",
            "16/KEEPT",
            "16/KEPTEN",
            "17/PUT",
            "17/PUTTEN",
            "17/PUTTED",
            "17/PUTING",
            "18/MIGHT",
            "18/MAYED",
            "18/MAY",
            "18/MIGHTEN",
            "19/HELD",
            "19/HOLDED",
            "19/HELDEN",
            "19/HOLD",
            "20/LEFT",
            "20/LEAVED",
            "20/LEFTEN",
            "20/LEAVE",
            "21/HEARD",
            "21/HEARED",
            "21/HEARDEN",
            "21/HEAR",
            "22/STOOD",
            "22/STANDED",
            "22/STOODEN",
            "22/STAND",
            "23/FELL",
            "23/FALLED",
            "23/FALLEN",
            "23/FALL",
            "24/LEARNT",
            "24/LEARN",
            "24/LEARNEDEN",
            "24/LEARNED",
            "25/MEANT",
            "25/MEANED",
            "25/MEANTEN",
            "25/MEAN",
            "26/BUILT",
            "26/BUILDED",
            "26/BUILDING",
            "26/BUILD",
            "27/BURNED",
            "27/BURN",
            "27/BURNT",
            "27/BURNING",
            "28/BOUGHT",
            "28/BUY",
            "28/BUYED",
            "28/BOUGHTEN",
            "29/TAUGHT",
            "29/TEACHED",
            "29/TAUGHTEN",
            "29/TEACH",
            "30/FOUGHT",
            "30/FIGHTED",
            "30/FOUGHTEN",
            "30/FIGHT",
            "31/THOUGHT",
            "31/THINK",
            "31/THINKED",
            "31/THOUGHTEN",
            "32/LENT",
            "32/LENDED",
            "32/LENTEN",
            "32/LEND",
            "33/LOST",
            "33/LOSED",
            "33/LOSTEN",
            "33/LOSE",
            "34/MISTOOK",
            "34/MISTAKED",
            "34/MISTAKEN",
            "34/MISTAKE",
            "35/WON",
            "35/WINED",
            "35/WONNEN",
            "35/WIN",
            "36/BROKE",
            "36/BREAKED",
            "36/BROKEN",
            "36/BREAK",
            "37/CHOSEN",
            "37/CHOOSED",
            "37/CHOSEN",
            "37/CHOOSE",
            "38/DRANK",
            "38/DRINKED",
            "38/DRUNKEN",
            "38/DRINK",
            "39/FORGOT",
            "39/FORGETTED",
            "39/FORGOTTEN",
            "39/FORGET",
            "40/FORGAVE",
            "40/FORGIVED",
            "40/FORGIVEN",
            "40/FORGIVE",
            "41/SLEPT",
            "41/SLEEPED",
            "41/SLEPTEN",
            "41/SLEEP",
            "42/SWAM",
            "42/SWIMMED",
            "42/SWUM",
            "42/SWIM",
            "43/RODE",
            "43/RODE",
            "43/RIDDEN",
            "43/RIDE",
            "44/RAN",
            "44/RUNED",
            "44/RUNNEN",
            "44/RUN",
            "45/ATE",
            "45/EATED",
            "45/EATEN",
            "45/EAT",
            "46/WORE",
            "46/WEARED",
            "46/WORN",
            "46/WEAR",
            "47/DROVE",
            "47/DRIVED",
            "47/DRIVEN",
            "47/DRIVE",
            "48/RANG",
            "48/RINGED",
            "48/RUNG",
            "48/RING",
            "49/ROSE",
            "49/RISED",
            "49/RISEN",
            "49/RISE",
            "50/WROTE",
            "50/WRITED",
            "50/WRITTEN",
            "50/WRITE"
        };
            
        Random rnd = new Random();
        Random plat = new Random();

        private int[] used = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private int counter = 0, index, timeSec = 3, health = 3, Time = 6, points = 0, rounds = 0, background_time;
        private bool right, left, jump, on_platform, gameON = true, pause = false;
        private int gravity = 20, force;
        


        Font LargeFont = new Font("Palatino Linotype", 20);

        private string platform_number = "none", answer, verb, rightAnswer;


        public PlatformVerbsForm()
        {
            InitializeComponent();

            Timer.Text = timeSec.ToString();
            Player.Location = new Point(600, 230);
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
            //checking if game is on
            #region

            if (gameON)
            {
                Player.Visible = true;
                TheWord.Visible = true;
                answer1.Visible = true;
                answer2.Visible = true;
                answer3.Visible = true;
                answer4.Visible = true;
            }
            else
            {
                Timer.Text = "END";
                TheWord.Visible = false;
                answer1.Visible = false;
                answer2.Visible = false;
                answer3.Visible = false;
                answer4.Visible = false;
            }

            #endregion

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
                health--;
                if (health == 2)
                {
                    h3.Visible = false;
                }
                else if (health == 1)
                {
                    h2.Visible = false;
                }
                else if (health == 0)
                {
                    gameON = false;
                    h1.Visible = false;
                }

                if (health == 0)
                {
                    Player.Visible = false;
                }
                else
                {
                    Player.Location = new Point(600, 260);
                }
                
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
                                System.Diagnostics.Debug.WriteLine("Platform standing on: " + platform_number);
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
                    //System.Diagnostics.Debug.WriteLine("Platform standing on: " + platform_number);
                }
            }

            if (!on_platform)
            {
                jump = true;
            }
            #endregion

            //displaying verb
            #region
            void Verb_Display()
            {
                index = rnd.Next(0, 49);
                for (int k = 0; k < 49; k++) //checking if generated number is new
                {
                    if (used[k] == index)
                    {
                        index = rnd.Next(0, 49);
                        k = 0;
                    }
                }
                used[index] = index;
                verb = verbs[index + 1];
                //System.Diagnostics.Debug.WriteLine(verb);
                TheWord.Text = verb.Remove(0, 3);               //displayed verb

                int Plat = plat.Next(1, 5);
                answer = answers[(index + 1) * 4];              //displayed right answer
                if (Plat == 1)
                {
                    answer1.Text = answers[(index + 1) * 4].Remove(0, 3);
                    answer2.Text = answers[((index + 1) * 4) + 1].Remove(0, 3);
                    answer3.Text = answers[((index + 1) * 4) + 2].Remove(0, 3);
                    answer4.Text = answers[((index + 1) * 4) + 3].Remove(0, 3);
                    rightAnswer = "p1";
                }
                if (Plat == 2)
                {
                    answer2.Text = answers[(index + 1) * 4].Remove(0, 3);
                    answer3.Text = answers[((index + 1) * 4) + 1].Remove(0, 3);
                    answer4.Text = answers[((index + 1) * 4) + 2].Remove(0, 3);
                    answer1.Text = answers[((index + 1) * 4) + 3].Remove(0, 3);
                    rightAnswer = "p2";
                }
                if (Plat == 3)
                {
                    answer3.Text = answers[(index + 1) * 4].Remove(0, 3);
                    answer4.Text = answers[((index + 1) * 4) + 1].Remove(0, 3);
                    answer1.Text = answers[((index + 1) * 4) + 2].Remove(0, 3);
                    answer2.Text = answers[((index + 1) * 4) + 3].Remove(0, 3);
                    rightAnswer = "p3";
                }
                if (Plat >= 4)
                {
                    answer4.Text = answers[(index + 1) * 4].Remove(0, 3);
                    answer1.Text = answers[((index + 1) * 4) + 1].Remove(0, 3);
                    answer2.Text = answers[((index + 1) * 4) + 2].Remove(0, 3);
                    answer3.Text = answers[((index + 1) * 4) + 3].Remove(0, 3);
                    rightAnswer = "p4";
                }
                //System.Diagnostics.Debug.WriteLine(answers[(index + 1) * 4].Remove(0, 3));

                System.Diagnostics.Debug.WriteLine("health: " + health);
                System.Diagnostics.Debug.WriteLine("right platform: " + Plat);
                
            }   
            #endregion
   

            //gameON
            #region
            if (gameON)
            {
                if (pause == false) //constant timer if unpaused
                {
                    if (counter % 70 == 0)
                    {
                        if(timeSec == Time)
                        {
                            Verb_Display();
                        }

                        if (timeSec < 10)
                        {
                            Timer.Text = "0" + timeSec.ToString();
                        }
                        else
                        {
                            Timer.Text = timeSec.ToString();
                        }
                        counter = 0;
                        background_time++;
                        System.Diagnostics.Debug.WriteLine(background_time);
                        timeSec--;
                    }
                    counter++;
                }                                
                
                if (rounds == 0 && background_time == 4) //countdown to start
                {
                    pause = true;
                    if (counter %70==0)
                    {
                        Timer.Text = "00";
                        background_time++;
                        System.Diagnostics.Debug.WriteLine(background_time);
                        
                        counter = 69;
                        rounds++;
                        timeSec = Time;
                        pause = false;
                    }
                    counter++;       
                }

                if (rounds > 0 && timeSec == -1) //checking if Player chose bad answer
                {
                    pause = true;
                    if (counter % 70 == 0)
                    {
                        if (rightAnswer != platform_number)
                        {
                            health--;
                            if (health == 2)
                            {
                                h3.Visible = false;
                            }
                            else if (health == 1)
                            {
                                h2.Visible = false;
                            }
                            else if(health == 0)
                            {
                                gameON = false;
                                h1.Visible=false;
                            }
                        }
                        Timer.Text = "00";
                        background_time++;
                        counter = 69;
                        rounds++;
                        timeSec = Time;
                        pause = false;
                    }
                    counter++;
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

        private void TheWord_Click(object sender, EventArgs e)
        {

        }

        private void PlatformVerbsForm_Load(object sender, EventArgs e)
        {

        }
    }
}