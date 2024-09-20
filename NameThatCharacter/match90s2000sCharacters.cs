using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatCharacter
{
    public partial class Match90s2000sCharacters : Form
    {
        // declare variables
        int turnsTaken = 0;
        List<int> previouslyUsedIndices = new List<int>();
        int randomIndex;
        Random random = new Random();
        int correctAnswers = 0;
        int wrongAnswers = 0;
        int seconds = 60;
        int correctPercentage;


        public Match90s2000sCharacters()
        {
            InitializeComponent();
            UpdateCharacter();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void UpdateCharacter()
        {
            do
            {// if all of the indices have been used, clear the indices array to start over
                if (previouslyUsedIndices.Count == Class1.name.Length)
                    previouslyUsedIndices.Clear();

                // generate a random index between 0 and the number of names
                // the random index variable will be used to put a random image and name in the game for each turn
                randomIndex = random.Next(0, Class1.name.Length);
            }
            while (previouslyUsedIndices.Contains(randomIndex));

            previouslyUsedIndices.Add(randomIndex);

            // get the charcter's image in the picture box
            // we are changing the image to a random image from the characterPics array of images
            pictureBox90s2000s.Image = Class1.characterPics[randomIndex];


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Make a variable that will count each turn taken, and increment it each time 
            // the submit button is clicked
            turnsTaken++;

            // Next we want to compare the user input with the actual answer
            // so first we will get the user input
            string userInput = textBox90s2000s.Text;

            // Next we will get the answer
            string characterNameAnswer = Class1.name[randomIndex];

            // If the user input matches the answer, the user got the question right
            if (userInput.ToLower() == characterNameAnswer.ToLower())
            {
                // add 1 to the correctAnswers variable
                correctAnswers++;

                // change the score to update the number of correct answers
                currentScoreLabel.Text = $"Score: {correctAnswers}";

                //change the label to show that the user got the answer right
                label90s2000sGameWindow.Text = "Correct!";

            }

            else
            {
                // if the answer was incorrect, change the label to say incorrect
                label90s2000sGameWindow.Text = $"Incorrect! The correct answer was {Class1.name[randomIndex]}";

                // increment the number of wrong answers variable
                wrongAnswers++;
            }

            // after the user submits their answer, clear the textbox and update the character
            textBox90s2000s.Text = "";
            UpdateCharacter();
        }

        private void skipCharacterButton_Click(object sender, EventArgs e)
        {
            UpdateCharacter();

            // Change the label to show that the question was skipped
            label90s2000sGameWindow.Text = "Question Skipped";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // increment the seconds by 1, counting backwards
            seconds--;

            // update the timer label
            timerLabel.Text = $"Time: {seconds}";

            // When the timer reaches 0, show the end game screen
            if (seconds == 0)
            {
                // stop the timer
                timer1.Stop();

                // Calculate the number of questions that were correct
                float correctPercentage = (float)correctAnswers / turnsTaken * 100f;

                // open stats form

                // declare the stats form as an object
                ResultWindowForm resultWindowForm = new ResultWindowForm(correctAnswers, turnsTaken, wrongAnswers, correctPercentage);

                // hide the parent form when the result window opens
                this.Hide();

                // open the stats form
                resultWindowForm.ShowDialog();



            }
        }

        private void Match90s2000sCharacters_FormClosed(object sender, FormClosedEventArgs e)
        {
            // stop the timer
            timer1.Stop();
        }
    }
}
