using System;
using System.Collections.Generic;
using Brightwave2.Models;
using Brightwave2.Views.Menu;
using Xamarin.Forms;

namespace Brightwave2.Views
{
    public partial class Report : ContentPage
    {
        public Report()
        {
            InitializeComponent();
           // NavigationPage.SetHasBackButton(this, true);

            Init();
        }

        void Init()
        {
            saveButton.TextColor = Constants.ButtonText;
        }
    }
}
