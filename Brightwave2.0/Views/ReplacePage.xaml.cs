using System;
using System.Collections.Generic;
using Brightwave2.Models;
using Xamarin.Forms;

namespace Brightwave2.Views
{
    public partial class ReplacePage : ContentPage
    {
        public ReplacePage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            ActivitySpinner.IsVisible = false;

            BackgroundColor = Constants.BackGroundColor;
            serialLabel.TextColor = Constants.TextColor;
            newSerialLabel.TextColor = Constants.TextColor;
            coordinatesLabel.TextColor = Constants.TextColor;
            submitButton.TextColor = Constants.ButtonText;

            serialText.Completed += (s, e) => newSerialText.Focus();
            newSerialText.Completed += (s, e) => coordinatesText.Focus();
            coordinatesText.Completed += (s, e) => SubmitProcedure(s, e);

        }

        void SubmitProcedure(object sender, EventArgs e)
        {
            
        }
    }
}
