namespace JPWP_Platform_Verbs
{
    public partial class PlatformVerbsForm : Form
    {
        private bool right, left, jump;
        private int gravity = 25;
        private int force;

        public PlatformVerbsForm()
        {
            InitializeComponent();            
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) { right = true; }
            if (e.KeyCode == Keys.A) { left = true; }

            if (!jump)
            {
                if (e.KeyCode == Keys.W)
                {
                    jump = true;
                    force = gravity;
                }
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.A) { left = false; }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (right) { Player.Left += 5; }
            if (left) { Player.Left -= 5; }

            if (jump)
            {
                Player.Top -= force;
                force -= 1;
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
        }
    }
}