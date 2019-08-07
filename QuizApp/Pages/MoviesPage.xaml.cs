using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuizApp
{
    public partial class MoviesPage : ContentPage
    {

        string allQuestion = Question();

        private static string Question()
        {
            throw new NotImplementedException();
        }

        bool pickedAnswer = false;
        int questionNumber = 0;

        public void nextQuestion()
        {
            if (questionNumber <= 5)
            {
                questionLabel.Text = "hello";
            }
        }

        void True_Handle_Clicked(object sender, System.EventArgs e)
        {

        }

        void Back_Handle_Clicked(object sender, System.EventArgs e)
        {
            var onBack = Application.Current as App;
            onBack.Back();
        }

        void False_Handle_Clicked(object sender, System.EventArgs e)
        {

        }

        public MoviesPage()
        {
            InitializeComponent();
        }
    }
}
