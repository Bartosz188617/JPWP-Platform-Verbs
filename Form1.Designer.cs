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
            Player = new PictureBox();
            Platform3 = new PictureBox();
            Platform4 = new PictureBox();
            Platform2 = new PictureBox();
            Platform1 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            GameScene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 17;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // GameScene
            // 
            GameScene.BackColor = SystemColors.Control;
            GameScene.Controls.Add(pictureBox5);
            GameScene.Controls.Add(pictureBox4);
            GameScene.Controls.Add(pictureBox3);
            GameScene.Controls.Add(Player);
            GameScene.Controls.Add(Platform3);
            GameScene.Controls.Add(Platform4);
            GameScene.Controls.Add(Platform2);
            GameScene.Controls.Add(Platform1);
            GameScene.Controls.Add(pictureBox1);
            GameScene.Controls.Add(pictureBox2);
            GameScene.Location = new Point(10, 10);
            GameScene.Margin = new Padding(0);
            GameScene.Name = "GameScene";
            GameScene.Size = new Size(1280, 700);
            GameScene.TabIndex = 0;
            // 
            // Player
            // 
            Player.BackColor = SystemColors.Control;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(617, 250);
            Player.Margin = new Padding(0);
            Player.Name = "Player";
            Player.Size = new Size(50, 50);
            Player.TabIndex = 0;
            Player.TabStop = false;
            Player.UseWaitCursor = true;
            Player.Click += Player_Click;
            // 
            // Platform3
            // 
            Platform3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Platform3.BackColor = SystemColors.ActiveCaption;
            Platform3.Image = (Image)resources.GetObject("Platform3.Image");
            Platform3.Location = new Point(255, 450);
            Platform3.Margin = new Padding(0);
            Platform3.Name = "Platform3";
            Platform3.Size = new Size(150, 20);
            Platform3.TabIndex = 4;
            Platform3.TabStop = false;
            Platform3.Tag = "Plat";
            // 
            // Platform4
            // 
            Platform4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Platform4.BackColor = SystemColors.ActiveCaption;
            Platform4.Image = (Image)resources.GetObject("Platform4.Image");
            Platform4.Location = new Point(565, 300);
            Platform4.Margin = new Padding(0);
            Platform4.Name = "Platform4";
            Platform4.Size = new Size(150, 20);
            Platform4.TabIndex = 3;
            Platform4.TabStop = false;
            Platform4.Tag = "Plat";
            // 
            // Platform2
            // 
            Platform2.BackColor = SystemColors.ActiveCaption;
            Platform2.Image = (Image)resources.GetObject("Platform2.Image");
            Platform2.Location = new Point(863, 450);
            Platform2.Margin = new Padding(0);
            Platform2.Name = "Platform2";
            Platform2.Size = new Size(150, 20);
            Platform2.TabIndex = 2;
            Platform2.TabStop = false;
            Platform2.Tag = "Plat";
            // 
            // Platform1
            // 
            Platform1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Platform1.BackColor = SystemColors.ActiveCaption;
            Platform1.Image = (Image)resources.GetObject("Platform1.Image");
            Platform1.Location = new Point(565, 600);
            Platform1.Margin = new Padding(0);
            Platform1.Name = "Platform1";
            Platform1.Size = new Size(150, 20);
            Platform1.TabIndex = 1;
            Platform1.TabStop = false;
            Platform1.Tag = "Plat";
            Platform1.Click += Platform1_Click;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(640, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(640, 700);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(59, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(115, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // PlatformVerbsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 731);
            Controls.Add(GameScene);
            Name = "PlatformVerbsForm";
            Text = "Platform Verb";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            GameScene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel GameScene;
        private PictureBox Player;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox Platform1;
        private PictureBox Platform2;
        private PictureBox Platform3;
        private PictureBox Platform4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}