using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogTriviaQuiz
{
    public partial class Form1 : Form
    {

        //quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int timeLeft;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again!"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.eyes;

                    lblQuestion.Text = "How many eyelids does a dog have?";

                    button1.Text = "One";
                    button2.Text = "Two";
                    button3.Text = "Three";
                    button4.Text = "Four";

                    correctAnswer = 3;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.sweat;

                    lblQuestion.Text = "If dogs get too hot, they sweat. Where do they sweat from?";

                    button1.Text = "Their eyes";
                    button2.Text = "Their tongues";
                    button3.Text = "Their ears";
                    button4.Text = "Their paws";

                    correctAnswer = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.collie;

                    lblQuestion.Text = "Which breed of dog is often considered the most intelligent?";

                    button1.Text = "Border Collie";
                    button2.Text = "German Shephard";
                    button3.Text = "French Bulldog";
                    button4.Text = "Mastiff";

                    correctAnswer = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.labrador;

                    lblQuestion.Text = "Which breed of dog is the most popular in the USA?";

                    button1.Text = "Jindo";
                    button2.Text = "Labrador Retriever";
                    button3.Text = "Weimaraner";
                    button4.Text = "Maltese";

                    correctAnswer = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.mastiff;

                    lblQuestion.Text = "Hagrid from Harry Potter has a dog - what is the dog’s name?";

                    button1.Text = "Spider";
                    button2.Text = "Dracula";
                    button3.Text = "Fang";
                    button4.Text = "Bunny";

                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.cerberus;

                    lblQuestion.Text = "In ancient mythology, what is the name of the 3-headed dog that guards the underworld?";

                    button1.Text = "Cerberus";
                    button2.Text = "Hercules";
                    button3.Text = "Atlas";
                    button4.Text = "Hades";

                    correctAnswer = 1;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.hound;

                    lblQuestion.Text = "What sort of dog did Elvis sing about?";

                    button1.Text = "Hunting";
                    button2.Text = "Pound";
                    button3.Text = "Hound";
                    button4.Text = "Mutt";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.dog;

                    lblQuestion.Text = "Which English artist had a hit with the song ‘The Dog Days Are Over’?";

                    button1.Text = "Pink Floyd";
                    button2.Text = "David Bowie";
                    button3.Text = "The Beatles";
                    button4.Text = "Florence and the Machine";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.scottish;

                    lblQuestion.Text = "In Monopoly, one of the game pieces is a small dog. What breed is it? ";

                    button1.Text = "Scottish Terrier";
                    button2.Text = "Cairn Terrier";
                    button3.Text = "Australian Terrier";
                    button4.Text = "Boston Terrier";

                    correctAnswer = 1;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.dachshund;

                    lblQuestion.Text = "Dachshunds were originally bred to hunt what animal? ";

                    button1.Text = "Bunnies";
                    button2.Text = "Badgers";
                    button3.Text = "Snakes";
                    button4.Text = "Boars";

                    correctAnswer = 2;

                    break;


            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
