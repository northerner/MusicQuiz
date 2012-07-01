using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MusicQuiz
{
    public partial class Form1 : Form
    {
        Quiz quiz;
        Random random;
        Player player;

        Song correctAnswer;
        int answerNum;

        public Form1()
        {
            InitializeComponent();
            this.random = new Random();
        }


        private void folderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath.ToString());
                quiz = new Quiz(folderBrowserDialog1.SelectedPath, random);
            }
        }

        private void newQuestionButton_Click(object sender, EventArgs e)
        {
            if (quiz == null)
            {
                MessageBox.Show("Please select your music folder");
                return;
            }
            Question question = quiz.newQuestion();
            Song answer1 = question.answer1;
            Song answer2 = question.answer2;
            Song answer3 = question.answer3;
            
            option1Button.Text = answer1.artist;
            option2Button.Text = answer2.artist;
            option3Button.Text = answer3.artist;

            answerNum = random.Next(1, 3);
            if (answerNum == 1)
                correctAnswer = answer1;
            else if (answerNum == 2)
                correctAnswer = answer2;
            else
                correctAnswer = answer3;

            player = new Player(correctAnswer.path);
        }

        private void answerCheck(int answerNumber)
        {
            if (answerNumber == this.answerNum)
            {
                feedbackLabel.Text = "Correct! well done.";
                player.CloseWaveOut();
            }
            else
            {
                feedbackLabel.Text = "Wrong, try again";
            }
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            answerCheck(1);
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            answerCheck(2);
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            answerCheck(3);
        }

    }
}
