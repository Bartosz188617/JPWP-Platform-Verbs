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
            gameTimer = new System.Windows.Forms.Timer(components);
            GameScene = new Panel();
            Player = new PictureBox();
            Platform5 = new PictureBox();
            Platform3 = new PictureBox();
            Platform4 = new PictureBox();
            Platform2 = new PictureBox();
            Platform1 = new PictureBox();
            GameScene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Platform1).BeginInit();
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
            GameScene.BackColor = Color.LightSkyBlue;
            GameScene.Controls.Add(Player);
            GameScene.Controls.Add(Platform5);
            GameScene.Controls.Add(Platform3);
            GameScene.Controls.Add(Platform4);
            GameScene.Controls.Add(Platform2);
            GameScene.Controls.Add(Platform1);
            GameScene.Location = new Point(10, 10);
            GameScene.Margin = new Padding(0);
            GameScene.Name = "GameScene";
            GameScene.Size = new Size(1280, 700);
            GameScene.TabIndex = 0;
            // 
            // Player
            // 
            Player.BackColor = SystemColors.Control;
            Player.Location = new Point(559, 230);
            Player.Margin = new Padding(0);
            Player.Name = "Player";
            Player.Size = new Size(50, 50);
            Player.TabIndex = 0;
            Player.TabStop = false;
            Player.UseWaitCursor = true;
            Player.Click += Player_Click;
            // 
            // Platform5
            // 
            Platform5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Platform5.BackColor = SystemColors.ActiveCaption;
            Platform5.Location = new Point(19, 386);
            Platform5.Margin = new Padding(0);
            Platform5.Name = "Platform5";
            Platform5.Size = new Size(300, 10);
            Platform5.TabIndex = 5;
            Platform5.TabStop = false;
            Platform5.Tag = "Plat";
            // 
            // Platform3
            // 
            Platform3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Platform3.BackColor = SystemColors.ActiveCaption;
            Platform3.Location = new Point(340, 470);
            Platform3.Margin = new Padding(0);
            Platform3.Name = "Platform3";
            Platform3.Size = new Size(300, 10);
            Platform3.TabIndex = 4;
            Platform3.TabStop = false;
            Platform3.Tag = "Plat";
            // 
            // Platform4
            // 
            Platform4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Platform4.BackColor = SystemColors.ActiveCaption;
            Platform4.Location = new Point(438, 308);
            Platform4.Margin = new Padding(0);
            Platform4.Name = "Platform4";
            Platform4.Size = new Size(300, 10);
            Platform4.TabIndex = 3;
            Platform4.TabStop = false;
            Platform4.Tag = "Plat";
            // 
            // Platform2
            // 
            Platform2.BackColor = SystemColors.ActiveCaption;
            Platform2.Location = new Point(751, 531);
            Platform2.Margin = new Padding(0);
            Platform2.Name = "Platform2";
            Platform2.Size = new Size(300, 10);
            Platform2.TabIndex = 2;
            Platform2.TabStop = false;
            Platform2.Tag = "Plat";
            // 
            // Platform1
            // 
            Platform1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Platform1.BackColor = SystemColors.ActiveCaption;
            Platform1.Location = new Point(340, 604);
            Platform1.Margin = new Padding(0);
            Platform1.Name = "Platform1";
            Platform1.Size = new Size(300, 10);
            Platform1.TabIndex = 1;
            Platform1.TabStop = false;
            Platform1.Tag = "Plat";
            Platform1.Click += Platform1_Click;
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
            ((System.ComponentModel.ISupportInitialize)Platform5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Platform1).EndInit();
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
        private PictureBox Platform5;
    }
}