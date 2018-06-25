using System;

using Xamarin.Forms;

namespace Brightwave2.Views.MainPages
{
    public class NewInstall : ContentPage
    {
        public NewInstall()
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

