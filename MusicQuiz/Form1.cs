﻿using System;
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
        int score;
        double time;
        // 'answered' bool prevents starting multiple questions
        // before finishing the current question
        bool answered;

        Song correctAnswer;
        int answerNum;

        public Form1()
        {
            InitializeComponent();
            this.random = new Random();
            time = 0.00;
            score = 0;
            answered = true;
        }


        private void folderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                option1Button.Visible = false;
                option2Button.Visible = false;
                option3Button.Visible = false;
                folderButton.Visible = false;
                newQuestionButton.Visible = false;
                feedbackLabel.Text = "Searching for MP3s. Please Wait.";
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void newQuestionButton_Click(object sender, EventArgs e)
        {
            if (quiz == null)
            {
                MessageBox.Show("Please select your music folder");
                return;
            }
            if (answered == false)
            {
                return;
            }
            answered = false;

            Question question = quiz.newQuestion();
            Song answer1 = question.answer1;
            Song answer2 = question.answer2;
            Song answer3 = question.answer3;
            
            option1Button.Text = answer1.artist;
            option2Button.Text = answer2.artist;
            option3Button.Text = answer3.artist;

            answerNum = random.Next(1, 4);
            if (answerNum == 1)
                correctAnswer = answer1;
            else if (answerNum == 2)
                correctAnswer = answer2;
            else
                correctAnswer = answer3;

            player = new Player(correctAnswer.path);
            songTimer.Start();
        }

        private bool answerCheck(int answerNumber)
        {
            if (answerNumber == this.answerNum)
            {
                songTimer.Stop();
                score += returnScore(this.time);
                time = 0;
                scroreTimerLabel.Text = "Score: " + score.ToString();
                feedbackLabel.Text = "Correct! well done.";
                player.CloseWaveOut();
                return true;
            }
            else
            {
                feedbackLabel.Text = "Wrong, try again";
                return false;
            }
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            answered = answerCheck(1);
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            answered = answerCheck(2);
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            answered = answerCheck(3);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            quiz = new Quiz(folderBrowserDialog1.SelectedPath, random);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
            MessageBox.Show("Total songs added: " + quiz.songs.Count.ToString());
            option1Button.Visible = true;
            option2Button.Visible = true;
            option3Button.Visible = true;
            folderButton.Visible = true;
            newQuestionButton.Visible = true;
            feedbackLabel.Text = "Hit 'New Question' to begin";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cleanup NAudio resources on application quit
            if (player != null)
            {
                player.CloseWaveOut();
            }
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            time += 0.01;
            scroreTimerLabel.Text = "";
            scroreTimerLabel.Text = "Time: " + time.ToString();
        }

        private int returnScore(double time)
        {
            if (time < 0.80)
                return 10;
            if (time < 1.00)
                return 8;
            if (time < 3.00)
                return 6;
            if (time < 6.00)
                return 3;
            if (time < 10.00)
                return 2;
            else
                return 1;
        }

    }
}
