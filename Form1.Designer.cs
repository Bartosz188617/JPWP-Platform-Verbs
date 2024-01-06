namespace JPWP_Platform_Verbs
{
    partial class PlatformVerbsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatformVerbsForm));
            gameTimer = new System.Windows.Forms.Timer(components);
            GameScene = new Panel();
            HighscoreLabel = new Label();
            VerbLabel = new Label();
            TimeLabel = new Label();
            PointCounter = new Label();
            PointsLabel = new Label();
            Verbs_data = new FlowLayoutPanel();
            panel4 = new Panel();
            verbsData = new Label();
            ListOfVerbs = new Label();
            Title = new Label();
            pausing = new FlowLayoutPanel();
            panel3 = new Panel();
            pause_button = new Label();
            SlideMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuButton = new PictureBox();
            start_stop = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            Timer = new Label();
            answer1 = new Label();
            answer2 = new Label();
            answer4 = new Label();
            answer3 = new Label();
            TheWord = new Label();
            h3 = new PictureBox();
            h2 = new PictureBox();
            h1 = new PictureBox();
            Player = new PictureBox();
            p3 = new PictureBox();
            p4 = new PictureBox();
            p2 = new PictureBox();
            p1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            SlideMenuTimer = new System.Windows.Forms.Timer(components);
            HighScoreCounter = new Label();
            GameScene.SuspendLayout();
            Verbs_data.SuspendLayout();
            panel4.SuspendLayout();
            pausing.SuspendLayout();
            panel3.SuspendLayout();
            SlideMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuButton).BeginInit();
            start_stop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)h3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)h2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)h1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 5;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // GameScene
            // 
            GameScene.BackColor = SystemColors.Control;
            GameScene.Controls.Add(HighScoreCounter);
            GameScene.Controls.Add(HighscoreLabel);
            GameScene.Controls.Add(VerbLabel);
            GameScene.Controls.Add(TimeLabel);
            GameScene.Controls.Add(PointCounter);
            GameScene.Controls.Add(PointsLabel);
            GameScene.Controls.Add(Verbs_data);
            GameScene.Controls.Add(ListOfVerbs);
            GameScene.Controls.Add(Title);
            GameScene.Controls.Add(pausing);
            GameScene.Controls.Add(SlideMenu);
            GameScene.Controls.Add(start_stop);
            GameScene.Controls.Add(Timer);
            GameScene.Controls.Add(answer1);
            GameScene.Controls.Add(answer2);
            GameScene.Controls.Add(answer4);
            GameScene.Controls.Add(answer3);
            GameScene.Controls.Add(TheWord);
            GameScene.Controls.Add(h3);
            GameScene.Controls.Add(h2);
            GameScene.Controls.Add(h1);
            GameScene.Controls.Add(Player);
            GameScene.Controls.Add(p3);
            GameScene.Controls.Add(p4);
            GameScene.Controls.Add(p2);
            GameScene.Controls.Add(p1);
            GameScene.Controls.Add(pictureBox2);
            GameScene.Controls.Add(pictureBox1);
            GameScene.Location = new Point(10, 10);
            GameScene.Margin = new Padding(0);
            GameScene.Name = "GameScene";
            GameScene.Size = new Size(1280, 700);
            GameScene.TabIndex = 0;
            // 
            // HighscoreLabel
            // 
            HighscoreLabel.AutoSize = true;
            HighscoreLabel.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            HighscoreLabel.Location = new Point(369, 250);
            HighscoreLabel.Name = "HighscoreLabel";
            HighscoreLabel.Size = new Size(192, 36);
            HighscoreLabel.TabIndex = 22;
            HighscoreLabel.Text = "HIGH SCORE:";
            // 
            // VerbLabel
            // 
            VerbLabel.AutoSize = true;
            VerbLabel.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            VerbLabel.Location = new Point(207, 17);
            VerbLabel.Name = "VerbLabel";
            VerbLabel.Size = new Size(91, 36);
            VerbLabel.TabIndex = 21;
            VerbLabel.Text = "VERB:";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.Location = new Point(1074, 17);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(89, 36);
            TimeLabel.TabIndex = 20;
            TimeLabel.Text = "TIME:";
            // 
            // PointCounter
            // 
            PointCounter.AutoSize = true;
            PointCounter.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PointCounter.Location = new Point(729, 17);
            PointCounter.Name = "PointCounter";
            PointCounter.Size = new Size(43, 36);
            PointCounter.TabIndex = 19;
            PointCounter.Text = "00";
            // 
            // PointsLabel
            // 
            PointsLabel.AutoSize = true;
            PointsLabel.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PointsLabel.Location = new Point(601, 17);
            PointsLabel.Name = "PointsLabel";
            PointsLabel.Size = new Size(122, 36);
            PointsLabel.TabIndex = 18;
            PointsLabel.Text = "POINTS:";
            // 
            // Verbs_data
            // 
            Verbs_data.BackColor = Color.FromArgb(249, 78, 78);
            Verbs_data.Controls.Add(panel4);
            Verbs_data.Location = new Point(3, 282);
            Verbs_data.MaximumSize = new Size(200, 50);
            Verbs_data.Name = "Verbs_data";
            Verbs_data.Size = new Size(200, 50);
            Verbs_data.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.Controls.Add(verbsData);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(195, 45);
            panel4.TabIndex = 0;
            // 
            // verbsData
            // 
            verbsData.AutoSize = true;
            verbsData.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            verbsData.Location = new Point(-5, 7);
            verbsData.Name = "verbsData";
            verbsData.Size = new Size(204, 32);
            verbsData.TabIndex = 1;
            verbsData.Text = "Baza Wyrazów";
            verbsData.Click += verbsData_Click;
            // 
            // ListOfVerbs
            // 
            ListOfVerbs.AutoSize = true;
            ListOfVerbs.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListOfVerbs.Location = new Point(3, 347);
            ListOfVerbs.Name = "ListOfVerbs";
            ListOfVerbs.Size = new Size(0, 20);
            ListOfVerbs.TabIndex = 1;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.FromArgb(249, 78, 78);
            Title.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(369, 113);
            Title.Name = "Title";
            Title.Size = new Size(677, 107);
            Title.TabIndex = 2;
            Title.Text = "Platform Verbs";
            // 
            // pausing
            // 
            pausing.BackColor = Color.FromArgb(249, 78, 78);
            pausing.Controls.Add(panel3);
            pausing.Location = new Point(3, 226);
            pausing.MaximumSize = new Size(200, 50);
            pausing.Name = "pausing";
            pausing.Size = new Size(200, 50);
            pausing.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Controls.Add(pause_button);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 45);
            panel3.TabIndex = 0;
            // 
            // pause_button
            // 
            pause_button.AutoSize = true;
            pause_button.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            pause_button.Location = new Point(87, 7);
            pause_button.Name = "pause_button";
            pause_button.Size = new Size(93, 32);
            pause_button.TabIndex = 1;
            pause_button.Text = "Pauza";
            pause_button.Click += pause_button_Click;
            // 
            // SlideMenu
            // 
            SlideMenu.BackColor = Color.FromArgb(249, 78, 78);
            SlideMenu.Controls.Add(panel1);
            SlideMenu.Location = new Point(3, 114);
            SlideMenu.MaximumSize = new Size(200, 50);
            SlideMenu.MinimumSize = new Size(50, 50);
            SlideMenu.Name = "SlideMenu";
            SlideMenu.Size = new Size(200, 50);
            SlideMenu.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 7);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            // 
            // MenuButton
            // 
            MenuButton.BackgroundImageLayout = ImageLayout.Center;
            MenuButton.Image = (Image)resources.GetObject("MenuButton.Image");
            MenuButton.Location = new Point(7, 7);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(30, 30);
            MenuButton.SizeMode = PictureBoxSizeMode.CenterImage;
            MenuButton.TabIndex = 0;
            MenuButton.TabStop = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // start_stop
            // 
            start_stop.BackColor = Color.FromArgb(249, 78, 78);
            start_stop.Controls.Add(panel2);
            start_stop.Location = new Point(3, 170);
            start_stop.MaximumSize = new Size(200, 50);
            start_stop.Name = "start_stop";
            start_stop.Size = new Size(200, 50);
            start_stop.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 45);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 6);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 1;
            label2.Text = "Start";
            label2.Click += label2_Click;
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Timer.Location = new Point(1169, 17);
            Timer.Name = "Timer";
            Timer.Size = new Size(43, 36);
            Timer.TabIndex = 1;
            Timer.Tag = "";
            Timer.Text = "00";
            // 
            // answer1
            // 
            answer1.AutoSize = true;
            answer1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            answer1.Location = new Point(565, 620);
            answer1.Name = "answer1";
            answer1.Size = new Size(85, 36);
            answer1.TabIndex = 13;
            answer1.Text = "          ";
            answer1.TextAlign = ContentAlignment.TopCenter;
            // 
            // answer2
            // 
            answer2.AutoSize = true;
            answer2.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            answer2.Location = new Point(863, 470);
            answer2.Name = "answer2";
            answer2.Size = new Size(85, 36);
            answer2.TabIndex = 12;
            answer2.Text = "          ";
            answer2.TextAlign = ContentAlignment.TopCenter;
            // 
            // answer4
            // 
            answer4.AutoSize = true;
            answer4.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            answer4.Location = new Point(565, 320);
            answer4.Name = "answer4";
            answer4.Size = new Size(85, 36);
            answer4.TabIndex = 11;
            answer4.Text = "          ";
            answer4.TextAlign = ContentAlignment.TopCenter;
            // 
            // answer3
            // 
            answer3.AutoSize = true;
            answer3.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            answer3.Location = new Point(255, 470);
            answer3.Name = "answer3";
            answer3.Size = new Size(85, 36);
            answer3.TabIndex = 10;
            answer3.Text = "          ";
            answer3.TextAlign = ContentAlignment.TopCenter;
            // 
            // TheWord
            // 
            TheWord.AutoSize = true;
            TheWord.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TheWord.Location = new Point(304, 17);
            TheWord.Name = "TheWord";
            TheWord.Size = new Size(85, 36);
            TheWord.TabIndex = 1;
            TheWord.Text = "          ";
            TheWord.TextAlign = ContentAlignment.TopCenter;
            TheWord.Click += TheWord_Click;
            // 
            // h3
            // 
            h3.AccessibleName = "h3";
            h3.Image = (Image)resources.GetObject("h3.Image");
            h3.Location = new Point(129, 3);
            h3.Name = "h3";
            h3.Size = new Size(50, 50);
            h3.TabIndex = 9;
            h3.TabStop = false;
            // 
            // h2
            // 
            h2.AccessibleName = "h2";
            h2.Image = (Image)resources.GetObject("h2.Image");
            h2.Location = new Point(73, 3);
            h2.Name = "h2";
            h2.Size = new Size(50, 50);
            h2.TabIndex = 8;
            h2.TabStop = false;
            // 
            // h1
            // 
            h1.AccessibleName = "h1";
            h1.Image = (Image)resources.GetObject("h1.Image");
            h1.Location = new Point(17, 3);
            h1.Name = "h1";
            h1.Size = new Size(50, 50);
            h1.TabIndex = 7;
            h1.TabStop = false;
            // 
            // Player
            // 
            Player.BackColor = SystemColors.Control;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(613, 250);
            Player.Margin = new Padding(0);
            Player.Name = "Player";
            Player.Size = new Size(50, 50);
            Player.TabIndex = 0;
            Player.TabStop = false;
            Player.UseWaitCursor = true;
            Player.Click += Player_Click;
            // 
            // p3
            // 
            p3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p3.BackColor = SystemColors.ActiveCaption;
            p3.Image = (Image)resources.GetObject("p3.Image");
            p3.Location = new Point(255, 450);
            p3.Margin = new Padding(0);
            p3.Name = "p3";
            p3.Size = new Size(150, 20);
            p3.TabIndex = 4;
            p3.TabStop = false;
            p3.Tag = "Plat";
            // 
            // p4
            // 
            p4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p4.BackColor = SystemColors.ActiveCaption;
            p4.Image = (Image)resources.GetObject("p4.Image");
            p4.Location = new Point(565, 300);
            p4.Margin = new Padding(0);
            p4.Name = "p4";
            p4.Size = new Size(150, 20);
            p4.TabIndex = 3;
            p4.TabStop = false;
            p4.Tag = "Plat";
            // 
            // p2
            // 
            p2.BackColor = SystemColors.ActiveCaption;
            p2.Image = (Image)resources.GetObject("p2.Image");
            p2.Location = new Point(863, 450);
            p2.Margin = new Padding(0);
            p2.Name = "p2";
            p2.Size = new Size(150, 20);
            p2.TabIndex = 2;
            p2.TabStop = false;
            p2.Tag = "Plat";
            // 
            // p1
            // 
            p1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p1.BackColor = SystemColors.ActiveCaption;
            p1.Image = (Image)resources.GetObject("p1.Image");
            p1.Location = new Point(565, 600);
            p1.Margin = new Padding(0);
            p1.Name = "p1";
            p1.Size = new Size(150, 20);
            p1.TabIndex = 1;
            p1.TabStop = false;
            p1.Tag = "Plat";
            p1.Click += Platform1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(640, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(640, 700);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 700);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SlideMenuTimer
            // 
            SlideMenuTimer.Interval = 5;
            SlideMenuTimer.Tick += SlideMenuTimer_Tick;
            // 
            // HighScoreCounter
            // 
            HighScoreCounter.AutoSize = true;
            HighScoreCounter.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            HighScoreCounter.Location = new Point(567, 250);
            HighScoreCounter.Name = "HighScoreCounter";
            HighScoreCounter.Size = new Size(43, 36);
            HighScoreCounter.TabIndex = 23;
            HighScoreCounter.Text = "00";
            // 
            // PlatformVerbsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 731);
            Controls.Add(GameScene);
            Name = "PlatformVerbsForm";
            Text = "Platform Verb";
            Load += PlatformVerbsForm_Load;
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            GameScene.ResumeLayout(false);
            GameScene.PerformLayout();
            Verbs_data.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pausing.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            SlideMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuButton).EndInit();
            start_stop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)h3).EndInit();
            ((System.ComponentModel.ISupportInitialize)h2).EndInit();
            ((System.ComponentModel.ISupportInitialize)h1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)p3).EndInit();
            ((System.ComponentModel.ISupportInitialize)p4).EndInit();
            ((System.ComponentModel.ISupportInitialize)p2).EndInit();
            ((System.ComponentModel.ISupportInitialize)p1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel GameScene;
        private PictureBox Player;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox p1;
        private PictureBox p2;
        private PictureBox p3;
        private PictureBox p4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox h3;
        private PictureBox h2;
        private PictureBox h1;
        private Label TheWord;
        private Label answer1;
        private Label answer2;
        private Label answer4;
        private Label answer3;
        private Label Timer;
        private FlowLayoutPanel SlideMenu;
        private Panel panel1;
        private PictureBox MenuButton;
        private Label label1;
        private System.Windows.Forms.Timer SlideMenuTimer;
        private FlowLayoutPanel start_stop;
        private Panel panel2;
        private Label label2;
        private FlowLayoutPanel pausing;
        private Panel panel3;
        private Label pause_button;
        private Label Title;
        private FlowLayoutPanel Verbs_data;
        private Panel panel4;
        private Label verbsData;
        private Label ListOfVerbs;
        private Label PointCounter;
        private Label PointsLabel;
        private Label TimeLabel;
        private Label VerbLabel;
        private Label HighscoreLabel;
        private Label HighScoreCounter;
    }
}