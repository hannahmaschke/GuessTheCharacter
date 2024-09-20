namespace NameThatCharacter
{
    partial class statsFormMultipleChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statsFormMultipleChoice));
            statsFormLabel = new Label();
            statsLabel = new Label();
            cancelButton = new Button();
            playAgainButton = new Button();
            SuspendLayout();
            // 
            // statsFormLabel
            // 
            statsFormLabel.AutoSize = true;
            statsFormLabel.BackColor = Color.Transparent;
            statsFormLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statsFormLabel.Location = new Point(260, 46);
            statsFormLabel.Name = "statsFormLabel";
            statsFormLabel.Size = new Size(199, 48);
            statsFormLabel.TabIndex = 0;
            statsFormLabel.Text = "Your Stats:";
            // 
            // statsLabel
            // 
            statsLabel.AutoSize = true;
            statsLabel.BackColor = Color.Transparent;
            statsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statsLabel.Location = new Point(12, 131);
            statsLabel.Name = "statsLabel";
            statsLabel.Size = new Size(455, 64);
            statsLabel.TabIndex = 1;
            statsLabel.Text = "label111111111111111111111111111111\r\nqwerty\r\n";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 192, 128);
            cancelButton.Location = new Point(12, 405);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += button1_Click;
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.FromArgb(255, 192, 128);
            playAgainButton.Location = new Point(676, 405);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(112, 34);
            playAgainButton.TabIndex = 3;
            playAgainButton.Text = "Play Again";
            playAgainButton.UseVisualStyleBackColor = false;
            playAgainButton.Click += button2_Click;
            // 
            // statsFormMultipleChoice
            // 
            AcceptButton = playAgainButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = cancelButton;
            ClientSize = new Size(800, 450);
            Controls.Add(playAgainButton);
            Controls.Add(cancelButton);
            Controls.Add(statsLabel);
            Controls.Add(statsFormLabel);
            MaximizeBox = false;
            Name = "statsFormMultipleChoice";
            Text = "statsFormMultipleChoice";
            FormClosed += statsFormMultipleChoice_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statsFormLabel;
        private Label statsLabel;
        private Button cancelButton;
        private Button playAgainButton;
    }
}