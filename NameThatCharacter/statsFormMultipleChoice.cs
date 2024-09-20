using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatCharacter
{
    public partial class statsFormMultipleChoice : Form
    {
        public statsFormMultipleChoice(int correctAnswers, int turnsTaken, int wrongAnswers, float correctPercentage, int skippedQuestions, int questionsAnswered)
        {
            InitializeComponent();

            // show stats
            statsLabel.Text = ($"Game Over! Your score is {correctAnswers}.\n" +
                $"You answered {questionsAnswered} questions. \n " +
                   $"You got {correctAnswers} questions correct, and answered {wrongAnswers} questions incorrectly. \n"
                   + $"You skipped {skippedQuestions} questions. \n" +
                   $"You got {correctPercentage} percent of the questions right!");

            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void statsFormMultipleChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
