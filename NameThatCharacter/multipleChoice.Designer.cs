namespace NameThatCharacter
{
    partial class MultipleChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleChoice));
            multipleChoicePictureBox = new PictureBox();
            multpleChoiceLabel = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            cancelButton = new Button();
            skipButton = new Button();
            submitButton = new Button();
            scoreLabel = new Label();
            timerLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)multipleChoicePictureBox).BeginInit();
            SuspendLayout();
            // 
            // multipleChoicePictureBox
            // 
            multipleChoicePictureBox.BorderStyle = BorderStyle.FixedSingle;
            multipleChoicePictureBox.Location = new Point(296, 107);
            multipleChoicePictureBox.Name = "multipleChoicePictureBox";
            multipleChoicePictureBox.Size = new Size(268, 220);
            multipleChoicePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            multipleChoicePictureBox.TabIndex = 0;
            multipleChoicePictureBox.TabStop = false;
            // 
            // multpleChoiceLabel
            // 
            multpleChoiceLabel.AutoSize = true;
            multpleChoiceLabel.BackColor = Color.Transparent;
            multpleChoiceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multpleChoiceLabel.Location = new Point(99, 25);
            multpleChoiceLabel.Name = "multpleChoiceLabel";
            multpleChoiceLabel.Size = new Size(781, 45);
            multpleChoiceLabel.TabIndex = 1;
            multpleChoiceLabel.Text = "Choose the character's name from the below options:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Location = new Point(356, 450);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(141, 29);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Location = new Point(356, 415);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(356, 380);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(356, 345);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 192, 128);
            cancelButton.Location = new Point(12, 499);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // skipButton
            // 
            skipButton.BackColor = Color.FromArgb(255, 192, 128);
            skipButton.Location = new Point(374, 499);
            skipButton.Name = "skipButton";
            skipButton.Size = new Size(112, 34);
            skipButton.TabIndex = 4;
            skipButton.Text = "Skip Question";
            skipButton.UseVisualStyleBackColor = false;
            skipButton.Click += skipButton_Click_1;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 192, 128);
            submitButton.Location = new Point(768, 499);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(112, 34);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(641, 138);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(78, 32);
            scoreLabel.TabIndex = 6;
            scoreLabel.Text = "Score:";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(641, 202);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(80, 32);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "Timer:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MultipleChoice
            // 
            AcceptButton = submitButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = cancelButton;
            ClientSize = new Size(892, 545);
            Controls.Add(radioButton4);
            Controls.Add(timerLabel);
            Controls.Add(radioButton3);
            Controls.Add(scoreLabel);
            Controls.Add(radioButton2);
            Controls.Add(submitButton);
            Controls.Add(radioButton1);
            Controls.Add(skipButton);
            Controls.Add(cancelButton);
            Controls.Add(multpleChoiceLabel);
            Controls.Add(multipleChoicePictureBox);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "MultipleChoice";
            Text = "Guess that Character- Multiple Choice";
            FormClosed += MultipleChoice_FormClosed;
            ((System.ComponentModel.ISupportInitialize)multipleChoicePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox multipleChoicePictureBox;
        private Label multpleChoiceLabel;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button cancelButton;
        private Button skipButton;
        private Button submitButton;
        private Label scoreLabel;
        private Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}