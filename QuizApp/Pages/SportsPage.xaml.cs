using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuizApp
{
    public partial class SportsPage : ContentPage
    {
        public SportsPage()
        {
            InitializeComponent();
        }


        void True_Handle_Clicked(object sender, System.EventArgs e)
        {
            que.Text = "hello";
        }

        void Back_Handle_Clicked(object sender, System.EventArgs e)
        {
            var onBack = Application.Current as App;
            onBack.Back();
        }

        void False_Handle_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}
