namespace NameThatCharacter
{
    partial class Match90s2000sCharacters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Match90s2000sCharacters));
            pictureBox90s2000s = new PictureBox();
            label90s2000sGameWindow = new Label();
            textBox90s2000s = new TextBox();
            cancelButton = new Button();
            skipCharacterButton = new Button();
            submitButton = new Button();
            currentScoreLabel = new Label();
            timerLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox90s2000s).BeginInit();
            SuspendLayout();
            // 
            // pictureBox90s2000s
            // 
            pictureBox90s2000s.Location = new Point(304, 122);
            pictureBox90s2000s.Name = "pictureBox90s2000s";
            pictureBox90s2000s.Size = new Size(212, 203);
            pictureBox90s2000s.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox90s2000s.TabIndex = 0;
            pictureBox90s2000s.TabStop = false;
            // 
            // label90s2000sGameWindow
            // 
            label90s2000sGameWindow.AutoSize = true;
            label90s2000sGameWindow.BackColor = Color.Transparent;
            label90s2000sGameWindow.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label90s2000sGameWindow.Location = new Point(109, 26);
            label90s2000sGameWindow.Name = "label90s2000sGameWindow";
            label90s2000sGameWindow.Size = new Size(604, 76);
            label90s2000sGameWindow.TabIndex = 1;
            label90s2000sGameWindow.Text = "Type the name of the character, name as many \r\nas possible before the timer runs out!";
            // 
            // textBox90s2000s
            // 
            textBox90s2000s.Location = new Point(277, 346);
            textBox90s2000s.Name = "textBox90s2000s";
            textBox90s2000s.Size = new Size(262, 31);
            textBox90s2000s.TabIndex = 2;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 128, 128);
            cancelButton.ForeColor = SystemColors.ActiveCaptionText;
            cancelButton.Location = new Point(25, 444);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // skipCharacterButton
            // 
            skipCharacterButton.BackColor = Color.FromArgb(255, 128, 128);
            skipCharacterButton.ForeColor = SystemColors.ActiveCaptionText;
            skipCharacterButton.Location = new Point(359, 397);
            skipCharacterButton.Name = "skipCharacterButton";
            skipCharacterButton.Size = new Size(112, 34);
            skipCharacterButton.TabIndex = 4;
            skipCharacterButton.Text = "&Skip";
            skipCharacterButton.UseVisualStyleBackColor = false;
            skipCharacterButton.Click += skipCharacterButton_Click;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 128, 128);
            submitButton.ForeColor = SystemColors.ActiveCaptionText;
            submitButton.Location = new Point(667, 444);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(112, 34);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // currentScoreLabel
            // 
            currentScoreLabel.AutoSize = true;
            currentScoreLabel.BackColor = Color.Transparent;
            currentScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentScoreLabel.Location = new Point(648, 152);
            currentScoreLabel.Name = "currentScoreLabel";
            currentScoreLabel.Size = new Size(91, 32);
            currentScoreLabel.TabIndex = 6;
            currentScoreLabel.Text = "Score: ";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(648, 198);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(77, 32);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "Time:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Match90s2000sCharacters
            // 
            AcceptButton = submitButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = cancelButton;
            ClientSize = new Size(800, 501);
            Controls.Add(timerLabel);
            Controls.Add(currentScoreLabel);
            Controls.Add(submitButton);
            Controls.Add(skipCharacterButton);
            Controls.Add(cancelButton);
            Controls.Add(textBox90s2000s);
            Controls.Add(label90s2000sGameWindow);
            Controls.Add(pictureBox90s2000s);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            Name = "Match90s2000sCharacters";
            Text = "Match the Character!";
            FormClosed += Match90s2000sCharacters_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox90s2000s).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox90s2000s;
        private Label label90s2000sGameWindow;
        private TextBox textBox90s2000s;
        private Button cancelButton;
        private Button skipCharacterButton;
        private Button submitButton;
        private Label currentScoreLabel;
        private Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}