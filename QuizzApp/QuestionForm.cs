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

        public QuestionBuilder QB { get; set; }

        //THIS IS JUST A TEST FORM. WHOEVER IS DOING THE UI CAN CHANGE IT
        //THIS FORM WAS CREATED TO TEST THE JSON FILE AND SEE IF IT READS WELL

        //var generalBuilder = new QuestionBuilder("General");
        //string message = "Question:" + generalBuilder.Question + "\r\n" +
        //                 "Correct: " + generalBuilder.CorrectAnswer + "\r\n" +
        //                 "I1: " + generalBuilder.Incorrect1 + "\r\n" +
        //                 "I2: " + generalBuilder.Incorrect2 + "\r\n" +
        //                 "I3: " + generalBuilder.Incorrect3 + "\r\n";
        //
        //outputBox.Text = message;

        private void generalButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("General");

                while (true)
                {
                    if (QL.Contains(QB))
                    {
                        QB = new QuestionBuilder("General");
                    }
                    else
                    { 
                        QL.Add(QB);
                        break;
                    }
                }
            }
            QuizBuilder.LoadQuestionForm(QL);
            
        }
         
        private void musicButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("Music");

                while (true)
                {
                    if (QL.Contains(QB))
                    {
                        QB = new QuestionBuilder("Music");
                    }
                    else
                    {
                        QL.Add(QB);
                        break;
                    }
                }
            }


            QuizBuilder.LoadQuestionForm(QL);
        }

        private void filmsButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("Films");

                while (true)
                {
                    if (QL.Contains(QB))
                    {
                        QB = new QuestionBuilder("Films");
                    }
                    else
                    {
                        QL.Add(QB);
                        break;
                    }
                }
            }


            QuizBuilder.LoadQuestionForm(QL);
        }

        private void animalsButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("Animals");

                while (true)
                {
                    if (QL.Contains(QB))
                    {
                        QB = new QuestionBuilder("Animals");
                    }
                    else
                    {
                        QL.Add(QB);
                        break;
                    }
                }
            }


            QuizBuilder.LoadQuestionForm(QL);
        }
    }
}
