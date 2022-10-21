namespace QuizzApp
{
    partial class QuizForm
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
            this.labelQuestionNum = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonAnswerOne = new System.Windows.Forms.Button();
            this.buttonAnswerTwo = new System.Windows.Forms.Button();
            this.buttonAnswerThree = new System.Windows.Forms.Button();
            this.buttonAnswerFour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestionNum
            // 
            this.labelQuestionNum.AutoSize = true;
            this.labelQuestionNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestionNum.Location = new System.Drawing.Point(30, 18);
            this.labelQuestionNum.Name = "labelQuestionNum";
            this.labelQuestionNum.Size = new System.Drawing.Size(30, 25);
            this.labelQuestionNum.TabIndex = 0;
            this.labelQuestionNum.Text = "Q.";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(30, 56);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(38, 15);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "label1";
            // 
            // buttonAnswerOne
            // 
            this.buttonAnswerOne.Location = new System.Drawing.Point(39, 97);
            this.buttonAnswerOne.Name = "buttonAnswerOne";
            this.buttonAnswerOne.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerOne.TabIndex = 2;
            this.buttonAnswerOne.Text = "button1";
            this.buttonAnswerOne.UseVisualStyleBackColor = true;
            // 
            // buttonAnswerTwo
            // 
            this.buttonAnswerTwo.Location = new System.Drawing.Point(347, 97);
            this.buttonAnswerTwo.Name = "buttonAnswerTwo";
            this.buttonAnswerTwo.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerTwo.TabIndex = 3;
            this.buttonAnswerTwo.Text = "button2";
            this.buttonAnswerTwo.UseVisualStyleBackColor = true;
            // 
            // buttonAnswerThree
            // 
            this.buttonAnswerThree.Location = new System.Drawing.Point(39, 258);
            this.buttonAnswerThree.Name = "buttonAnswerThree";
            this.buttonAnswerThree.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerThree.TabIndex = 4;
            this.buttonAnswerThree.Text = "button3";
            this.buttonAnswerThree.UseVisualStyleBackColor = true;
            // 
            // buttonAnswerFour
            // 
            this.buttonAnswerFour.Location = new System.Drawing.Point(347, 258);
            this.buttonAnswerFour.Name = "buttonAnswerFour";
            this.buttonAnswerFour.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerFour.TabIndex = 5;
            this.buttonAnswerFour.Text = "button4";
            this.buttonAnswerFour.UseVisualStyleBackColor = true;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.buttonAnswerFour);
            this.Controls.Add(this.buttonAnswerThree);
            this.Controls.Add(this.buttonAnswerTwo);
            this.Controls.Add(this.buttonAnswerOne);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelQuestionNum);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelQuestionNum;
        private Label labelQuestion;
        private Button buttonAnswerOne;
        private Button buttonAnswerTwo;
        private Button buttonAnswerThree;
        private Button buttonAnswerFour;
    }
}