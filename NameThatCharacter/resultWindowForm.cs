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
    public partial class ResultWindowForm : Form
    {
        public ResultWindowForm(int correctAnswers, int turnsTaken, int wrongAnswers, float correctPercentage)
        {
            InitializeComponent();

            resultsLabel.Text = ($"Game Over! Your score is {correctAnswers}. You answered {turnsTaken} questions. \n " +
                   $"You got {correctAnswers} questions correct, and answered {wrongAnswers} questions incorrectly. " +
                   (correctPercentage == 100 ?
                   "100%! Hannah did it again!" :
                   $"You got {correctPercentage} percent of the questions right!"));
        }

        // show results
        

        private void playAgainButton_Click(object sender, EventArgs e)
        {

        }
    }
}
