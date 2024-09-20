namespace NameThatCharacter
{
    partial class ResultWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultWindowForm));
            resultWindowLabel = new Label();
            resultsLabel = new Label();
            cancelButton = new Button();
            playAgainButton = new Button();
            SuspendLayout();
            // 
            // resultWindowLabel
            // 
            resultWindowLabel.AutoSize = true;
            resultWindowLabel.BackColor = Color.Transparent;
            resultWindowLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultWindowLabel.ForeColor = SystemColors.ButtonHighlight;
            resultWindowLabel.Location = new Point(240, 74);
            resultWindowLabel.Name = "resultWindowLabel";
            resultWindowLabel.Size = new Size(273, 45);
            resultWindowLabel.TabIndex = 0;
            resultWindowLabel.Text = "Your Results Are:";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.BackColor = Color.Transparent;
            resultsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsLabel.ForeColor = SystemColors.ButtonHighlight;
            resultsLabel.Location = new Point(12, 168);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(202, 38);
            resultsLabel.TabIndex = 1;
            resultsLabel.Text = "results go here";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Chartreuse;
            cancelButton.Location = new Point(12, 404);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.Chartreuse;
            playAgainButton.Location = new Point(676, 404);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(112, 34);
            playAgainButton.TabIndex = 3;
            playAgainButton.Text = "Play Again!";
            playAgainButton.UseVisualStyleBackColor = false;
            playAgainButton.Click += playAgainButton_Click;
            // 
            // ResultWindowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(playAgainButton);
            Controls.Add(cancelButton);
            Controls.Add(resultsLabel);
            Controls.Add(resultWindowLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ResultWindowForm";
            Text = "Your Results!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultWindowLabel;
        private Label resultsLabel;
        private Button cancelButton;
        private Button playAgainButton;
    }
}