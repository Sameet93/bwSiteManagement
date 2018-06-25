using System;

using Xamarin.Forms;

namespace Brightwave2.Views
{
    public class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

