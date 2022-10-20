using QuizzApp.QuestionBuilders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        //THIS IS JUST A TEST FORM. WHOEVER IS DOING THE UI CAN CHANGE IT
        //THIS FORM WAS CREATED TO TEST THE JSON FILE AND SEE IF IT READS WELL

        private void generalButton_Click(object sender, EventArgs e)
        {
            var generalBuilder = new QuestionBuilder("General");
            string message = "Question:" + generalBuilder.Question + "\r\n" +
                             "Correct: " + generalBuilder.CorrectAnswer + "\r\n" +
                             "I1: " + generalBuilder.Incorrect1 + "\r\n" +
                             "I2: " + generalBuilder.Incorrect2 + "\r\n" +
                             "I3: " + generalBuilder.Incorrect3 + "\r\n";

            outputBox.Text = message;
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            var musicBuilder = new QuestionBuilder("Music");
            string message = "Question:" + musicBuilder.Question + "\r\n" +
                             "Correct: " + musicBuilder.CorrectAnswer + "\r\n" +
                             "I1: " + musicBuilder.Incorrect1 + "\r\n" +
                             "I2: " + musicBuilder.Incorrect2 + "\r\n" +
                             "I3: " + musicBuilder.Incorrect3 + "\r\n";

            outputBox.Text = message;
        }

        private void filmsButton_Click(object sender, EventArgs e)
        {
            var filmsBuilder = new QuestionBuilder("Films");
            string message = "Question:" + filmsBuilder.Question + "\r\n" +
                             "Correct: " + filmsBuilder.CorrectAnswer + "\r\n" +
                             "I1: " + filmsBuilder.Incorrect1 + "\r\n" +
                             "I2: " + filmsBuilder.Incorrect2 + "\r\n" +
                             "I3: " + filmsBuilder.Incorrect3 + "\r\n";

            outputBox.Text = message;
        }

        private void animalsButton_Click(object sender, EventArgs e)
        {
            var animalsBuilder = new QuestionBuilder("Animals");
            string message = "Question:" + animalsBuilder.Question + "\r\n" +
                             "Correct: " + animalsBuilder.CorrectAnswer + "\r\n" +
                             "I1: " + animalsBuilder.Incorrect1 + "\r\n" +
                             "I2: " + animalsBuilder.Incorrect2 + "\r\n" +
                             "I3: " + animalsBuilder.Incorrect3 + "\r\n";

            outputBox.Text = message;
        }
    }
}
