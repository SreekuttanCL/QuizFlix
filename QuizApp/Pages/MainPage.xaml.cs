using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        void Enter_Handle_Clicked(object sender, System.EventArgs e)
        {
            var Username_input = username.Text;
            var Password_input = password.Text;
            if (Username_input == null & Password_input == null)
            {
                Error.Text = "Invalid Username or Password";
            }
            else
            {
                var myApp = Application.Current as App;
                myApp.onEnter();

            }

        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
