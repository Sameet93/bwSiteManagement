using System;
using System.Collections.Generic;
using Brightwave2.Models;
using Xamarin.Forms;

namespace Brightwave2.Views
{
    public partial class InstallPage : ContentPage
    {
        public InstallPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackGroundColor;
            serialText.TextColor = Constants.TextColor;
            coordinatesText.TextColor = Constants.TextColor;
            addressText.TextColor = Constants.TextColor;

            serialText.Completed += (s, e) => coordinatesText.Focus();
            coordinatesText.Completed += (s, e) => addressText.Focus();



        }
    }
}
