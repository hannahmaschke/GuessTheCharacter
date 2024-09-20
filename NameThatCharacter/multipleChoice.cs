using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace NameThatCharacter
{
    public partial class MultipleChoice : Form
    {
        RadioButton[] radioButtonOptions = new RadioButton[4];
        public MultipleChoice()
        {
            InitializeComponent();
            radioButtonOptions[0] = radioButton1;
            radioButtonOptions[1] = radioButton2;
            radioButtonOptions[2] = radioButton3;
            radioButtonOptions[3] = radioButton4;

            UpdateCharacter();
        }

        // Variables
        int turnsTaken = 0;
        List<int> previouslyUsedIndices = new List<int>();
        int randomIndex;
        Random random = new Random();
        int correctAnswers = 0;
        int wrongAnswers = 0;
        int seconds = 60;
        int questionsAnswered;
        int correctPercentage;
        string correctRbAnswer;
        int skippedQuestions = 0;

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
            multipleChoicePictureBox.Image = Class1.characterPics[randomIndex];

            GenerateCorrectAnswer();
        }



        private void groupBoxMC_Enter(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateCorrectAnswer()
        {
            // generate wrong answers
            // get the correct character- the answer must match the name of the character in the picture

            // for each radio button i am getting a random name from the array of names
            foreach (RadioButton newAnswer in radioButtonOptions)
            {
                bool isDupe;
                string potentialAnswr;
                do
                {
                    isDupe = false;
                    potentialAnswr = Class1.name[random.Next(0, Class1.name.Length)];

                    // for each radio button i am getting a random name from the array of names
                    foreach (RadioButton writtenAnswer in radioButtonOptions)
                    {
                        // check if there are duplicates
                        if (writtenAnswer.Text == potentialAnswr)
                        {
                            isDupe = true;
                            break;
                        }
                    }
                } while (isDupe);

                newAnswer.Text = potentialAnswr;
            }

            // Choose a random answer- we will be replacing this with the correct answer
            // replace one of the options with the correct answer
            int randomAnswerIndex = random.Next(0, 4);
            radioButtonOptions[randomAnswerIndex].Text = Class1.name[randomIndex];
            correctRbAnswer = Class1.name[randomIndex];
        }



        private void submitButton_Click(object sender, EventArgs e)
        {
            // Make a variable that will count each turn taken, and increment it each time 
            // the submit button is clicked
            turnsTaken++;

            // Check which radiobutton is selected and store it in a variable
            RadioButton selectedRadioButton = new RadioButton();

            // Find which radio button is selected
            foreach (RadioButton radioButton in radioButtonOptions)
            {
                if (radioButton.Checked)
                {
                    selectedRadioButton = radioButton;
                    break;
                }
            }


            // check if the selected radio button is the correct answer
            if (selectedRadioButton.Text == correctRbAnswer) // what should go in here?
            {
                // increment the correct answer count
                correctAnswers++;

                // increment the score label
                scoreLabel.Text = $"Score: {correctAnswers}";

                // change the label to tell the user they got the answer correct
                multpleChoiceLabel.Text = "Correct!";


            }
            else
            {
                wrongAnswers++;

                // change the label to tell the user they got the answer wrong
                multpleChoiceLabel.Text = $"Incorrect! The correct answer was {correctRbAnswer}";

            }

            // generate correct answer each time submit is clicked

            UpdateCharacter();

            // clear the radio buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        // private void skipButton_Click(object sender, EventArgs e)
        //  {
        //  }

        private void skipButton_Click_1(object sender, EventArgs e)
        {
            UpdateCharacter();

            // incremement skipped questions for stats form
            skippedQuestions++;


            // Change the label to show that the question was skipped
            multpleChoiceLabel.Text = "Question Skipped";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // decrement the seconds
            seconds--;

            // update the seconds in the timer label each second
            timerLabel.Text = "Timer: " + seconds.ToString();

            // when the timer runs out, stop the timer and show the stats form
            if (seconds == 0)
            {
                timer1.Stop();

                // change label to game over
                multpleChoiceLabel.Text = "Game over!";

                // Calculate the number of questions that were correct
                float correctPercentage = (float)correctAnswers / turnsTaken * 100f;

                // calculate the number of questions answered
                questionsAnswered = correctAnswers + wrongAnswers;

                // add the stats form tomorrow
                statsFormMultipleChoice StatsFormMultipleChoice = new statsFormMultipleChoice(correctAnswers, turnsTaken, wrongAnswers, correctPercentage, skippedQuestions, questionsAnswered);
                this.Hide();
                StatsFormMultipleChoice.ShowDialog();
                this.Show();
            }
        }

        private void MultipleChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop(); 
        }
    }
}

// notes
// tomorrow add stats form and show the answers that the user got wrong
// change code so there are not duplicate answers- just need to fix correct answer duplicates
