using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brightwave2.Models;
using Brightwave2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Brightwave2.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
            BackgroundColor = Constants.BackGroundColor;
            userText.TextColor = Constants.TextColor;
            passText.TextColor = Constants.TextColor;
            userLabel.TextColor = Constants.TextColor;
            passLabel.TextColor = Constants.TextColor;
            loginButton.TextColor = Constants.ButtonText;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            userText.Completed += (s, e) => passText.Focus();
            passText.Completed += (s, e) => SignInProcedure(s, e);




        }
        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(userText.Text, passText.Text);
            if (user.CheckInfo())
            {
                DisplayAlert("Login", "Login Successful", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Ok");
            }

        }
        async void TestSegue(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new InstallPage());
           
            await Navigation.PushAsync(new InstallPage());
        }

      
    }
}
