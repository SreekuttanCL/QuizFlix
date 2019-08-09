using System;
using System.Collections.Generic;
using System.Diagnostics;
using QuizApp.Model;

using Xamarin.Forms;

namespace QuizApp
{
    public partial class MoviesPage : ContentPage
    {
        
        QuestionBank allQuestion;
        bool pickedAnswer = false;
        int questionNumber = 0;
        int score = 0;

        void True_Handle_Clicked(object sender, System.EventArgs e)
        {

            pickedAnswer = true;
            checkAnswer();

            nextQuestion();
        }

        void Back_Handle_Clicked(object sender, System.EventArgs e)
        {
            var onBack = Application.Current as App;
            onBack.Back();
        }

        void False_Handle_Clicked(object sender, System.EventArgs e)
        {

            pickedAnswer = false;
        }

        public MoviesPage()
        {
            
            InitializeComponent();
        }


        public void checkAnswer()
        {
            var correctAnswer = allQuestion.CorrectAnswer;
            if (correctAnswer = pickedAnswer)
            {
                Debug.WriteLine("hello");
            }
        }

        public void nextQuestion()
        {

            if(questionNumber <= 10)
            {
                questionLabel.Text = allQuestion.QuestionText;
            }
        }
    }
}
