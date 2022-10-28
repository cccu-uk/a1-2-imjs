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
    public partial class QuizForm : Form
    {
        QuestionForm QuestionForm = new QuestionForm();
        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonAnswerOne_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerOne);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerOne);
                QuizBuilder.QuestionNumber = 1;
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                QuizBuilder.correctCount = 0;
                this.Visible = false;
            }

        }

        private void buttonAnswerTwo_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerTwo);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerTwo);
                QuizBuilder.QuestionNumber = 1;
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                QuizBuilder.correctCount = 0;
                this.Visible = false;
            }

        }

        private void buttonAnswerThree_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerThree);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerThree);
                QuizBuilder.QuestionNumber = 1;
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                QuizBuilder.correctCount = 0;
                this.Visible = false;

            }

        }

        private void buttonAnswerFour_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerFour);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerFour);
                QuizBuilder.QuestionNumber = 1;                
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                QuizBuilder.correctCount = 0;
                this.Visible = false;
            }

        }
    }
}
