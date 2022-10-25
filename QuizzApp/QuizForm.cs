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
    }
}
