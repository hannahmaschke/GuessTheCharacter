namespace NameThatCharacter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox90s2000s = new PictureBox();
            pictureBox70sToPresent = new PictureBox();
            nameThatCharacterLabel = new Label();
            characters90sTo2000sLabel = new Label();
            multipleChoiceLevelLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox90s2000s).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox70sToPresent).BeginInit();
            SuspendLayout();
            // 
            // pictureBox90s2000s
            // 
            pictureBox90s2000s.BackColor = Color.Transparent;
            pictureBox90s2000s.BackgroundImageLayout = ImageLayout.None;
            pictureBox90s2000s.Image = (Image)resources.GetObject("pictureBox90s2000s.Image");
            pictureBox90s2000s.Location = new Point(36, 134);
            pictureBox90s2000s.Name = "pictureBox90s2000s";
            pictureBox90s2000s.Size = new Size(318, 364);
            pictureBox90s2000s.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox90s2000s.TabIndex = 0;
            pictureBox90s2000s.TabStop = false;
            pictureBox90s2000s.Click += pictureBox90s2000s_Click;
            // 
            // pictureBox70sToPresent
            // 
            pictureBox70sToPresent.BackColor = Color.Transparent;
            pictureBox70sToPresent.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox70sToPresent.Image = (Image)resources.GetObject("pictureBox70sToPresent.Image");
            pictureBox70sToPresent.Location = new Point(530, 166);
            pictureBox70sToPresent.Name = "pictureBox70sToPresent";
            pictureBox70sToPresent.Size = new Size(294, 287);
            pictureBox70sToPresent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox70sToPresent.TabIndex = 2;
            pictureBox70sToPresent.TabStop = false;
            pictureBox70sToPresent.Click += pictureBox70sToPresent_Click;
            // 
            // nameThatCharacterLabel
            // 
            nameThatCharacterLabel.AutoSize = true;
            nameThatCharacterLabel.BackColor = Color.FromArgb(255, 128, 255);
            nameThatCharacterLabel.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameThatCharacterLabel.ForeColor = Color.Maroon;
            nameThatCharacterLabel.Location = new Point(248, 38);
            nameThatCharacterLabel.Name = "nameThatCharacterLabel";
            nameThatCharacterLabel.Size = new Size(371, 43);
            nameThatCharacterLabel.TabIndex = 3;
            nameThatCharacterLabel.Text = "Name That Character!";
            // 
            // characters90sTo2000sLabel
            // 
            characters90sTo2000sLabel.AutoSize = true;
            characters90sTo2000sLabel.BackColor = Color.LightSalmon;
            characters90sTo2000sLabel.Location = new Point(36, 134);
            characters90sTo2000sLabel.Name = "characters90sTo2000sLabel";
            characters90sTo2000sLabel.Size = new Size(306, 50);
            characters90sTo2000sLabel.TabIndex = 4;
            characters90sTo2000sLabel.Text = "Click here to guess the character's \r\n                    name! ";
            characters90sTo2000sLabel.Click += characters90sTo2000sLabel_Click;
            // 
            // multipleChoiceLevelLabel
            // 
            multipleChoiceLevelLabel.AutoSize = true;
            multipleChoiceLevelLabel.BackColor = Color.FromArgb(255, 255, 128);
            multipleChoiceLevelLabel.Location = new Point(548, 134);
            multipleChoiceLevelLabel.Name = "multipleChoiceLevelLabel";
            multipleChoiceLevelLabel.Size = new Size(276, 50);
            multipleChoiceLevelLabel.TabIndex = 6;
            multipleChoiceLevelLabel.Text = "Click here to play with multiple\r\n                    choice!\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 450);
            Controls.Add(multipleChoiceLevelLabel);
            Controls.Add(characters90sTo2000sLabel);
            Controls.Add(nameThatCharacterLabel);
            Controls.Add(pictureBox70sToPresent);
            Controls.Add(pictureBox90s2000s);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Name that Character!";
            ((System.ComponentModel.ISupportInitialize)pictureBox90s2000s).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox70sToPresent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox90s2000s;
        private PictureBox pictureBox70sToPresent;
        private Label nameThatCharacterLabel;
        private Label characters90sTo2000sLabel;
        private Label multipleChoiceLevelLabel;
    }
}
