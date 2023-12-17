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
            Timer = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TheWord = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            Player = new PictureBox();
            p3 = new PictureBox();
            p4 = new PictureBox();
            p2 = new PictureBox();
            p1 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            GameScene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // GameScene
            // 
            GameScene.BackColor = SystemColors.Control;
            GameScene.Controls.Add(Timer);
            GameScene.Controls.Add(label4);
            GameScene.Controls.Add(label3);
            GameScene.Controls.Add(label2);
            GameScene.Controls.Add(label1);
            GameScene.Controls.Add(TheWord);
            GameScene.Controls.Add(pictureBox5);
            GameScene.Controls.Add(pictureBox4);
            GameScene.Controls.Add(pictureBox3);
            GameScene.Controls.Add(Player);
            GameScene.Controls.Add(p3);
            GameScene.Controls.Add(p4);
            GameScene.Controls.Add(p2);
            GameScene.Controls.Add(p1);
            GameScene.Controls.Add(pictureBox1);
            GameScene.Controls.Add(pictureBox2);
            GameScene.Location = new Point(10, 10);
            GameScene.Margin = new Padding(0);
            GameScene.Name = "GameScene";
            GameScene.Size = new Size(1280, 700);
            GameScene.TabIndex = 0;
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Timer.Location = new Point(1198, 17);
            Timer.Name = "Timer";
            Timer.Size = new Size(43, 36);
            Timer.TabIndex = 1;
            Timer.Tag = "";
            Timer.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(599, 620);
            label4.Name = "label4";
            label4.Size = new Size(84, 36);
            label4.TabIndex = 13;
            label4.Text = "VERB";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(898, 470);
            label3.Name = "label3";
            label3.Size = new Size(84, 36);
            label3.TabIndex = 12;
            label3.Text = "VERB";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(599, 320);
            label2.Name = "label2";
            label2.Size = new Size(84, 36);
            label2.TabIndex = 11;
            label2.Text = "VERB";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 470);
            label1.Name = "label1";
            label1.Size = new Size(84, 36);
            label1.TabIndex = 10;
            label1.Text = "VERB";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TheWord
            // 
            TheWord.AutoSize = true;
            TheWord.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TheWord.Location = new Point(276, 16);
            TheWord.Name = "TheWord";
            TheWord.Size = new Size(84, 36);
            TheWord.TabIndex = 1;
            TheWord.Text = "VERB";
            TheWord.TextAlign = ContentAlignment.TopCenter;
            TheWord.Click += TheWord_Click;
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
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(59, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
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
            // Player
            // 
            Player.BackColor = SystemColors.Control;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(366, 220);
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
            GameScene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)p3).EndInit();
            ((System.ComponentModel.ISupportInitialize)p4).EndInit();
            ((System.ComponentModel.ISupportInitialize)p2).EndInit();
            ((System.ComponentModel.ISupportInitialize)p1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label TheWord;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Timer;
    }
}