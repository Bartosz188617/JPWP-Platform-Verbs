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
            GameScene = new Panel();
            Player = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            GameScene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            SuspendLayout();
            // 
            // GameScene
            // 
            GameScene.Controls.Add(Player);
            GameScene.Location = new Point(10, 10);
            GameScene.Margin = new Padding(0);
            GameScene.Name = "GameScene";
            GameScene.Size = new Size(1280, 700);
            GameScene.TabIndex = 0;
            // 
            // Player
            // 
            Player.BackColor = SystemColors.ActiveCaptionText;
            Player.Location = new Point(73, 632);
            Player.Name = "Player";
            Player.Size = new Size(50, 50);
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 10;
            gameTimer.Tick += gameTimer_Tick;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel GameScene;
        private PictureBox Player;
        private System.Windows.Forms.Timer gameTimer;
    }
}