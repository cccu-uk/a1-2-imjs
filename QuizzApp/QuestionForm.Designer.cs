﻿namespace QuizzApp
{
    partial class QuestionForm
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
            this.generalButton = new System.Windows.Forms.Button();
            this.filmsButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.animalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generalButton
            // 
            this.generalButton.Location = new System.Drawing.Point(10, 8);
            this.generalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(202, 119);
            this.generalButton.TabIndex = 0;
            this.generalButton.Text = "General";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // filmsButton
            // 
            this.filmsButton.Location = new System.Drawing.Point(10, 133);
            this.filmsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmsButton.Name = "filmsButton";
            this.filmsButton.Size = new System.Drawing.Size(202, 119);
            this.filmsButton.TabIndex = 1;
            this.filmsButton.Text = "Films";
            this.filmsButton.UseVisualStyleBackColor = true;
            this.filmsButton.Click += new System.EventHandler(this.filmsButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.Location = new System.Drawing.Point(218, 8);
            this.musicButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(202, 119);
            this.musicButton.TabIndex = 2;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // animalsButton
            // 
            this.animalsButton.Location = new System.Drawing.Point(218, 133);
            this.animalsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animalsButton.Name = "animalsButton";
            this.animalsButton.Size = new System.Drawing.Size(200, 121);
            this.animalsButton.TabIndex = 3;
            this.animalsButton.Text = "Animals";
            this.animalsButton.UseVisualStyleBackColor = true;
            this.animalsButton.Click += new System.EventHandler(this.animalsButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 263);
            this.Controls.Add(this.animalsButton);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.filmsButton);
            this.Controls.Add(this.generalButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button generalButton;
        private Button filmsButton;
        private Button musicButton;
        private Button animalsButton;
    }
}