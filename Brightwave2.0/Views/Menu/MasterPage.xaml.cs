using System;
using System.Collections.Generic;
using Brightwave2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Brightwave2.Views;

namespace Brightwave2.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView Listview { get { return listview; } }
        public List<MasterMenuItem> items;
        public MasterPage()
        {
            InitializeComponent();
            Init();
            SetItems();
        }

        void Init()
        {
            logoutButton.TextColor = Constants.ButtonText;

            BackgroundColor = Color.Orange;
        }
        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("Profile", "profile.png", Color.Orange, typeof(Profile)));
            items.Add(new MasterMenuItem("Assets", "profile.png", Color.Orange, typeof(Tabs)));
            items.Add(new MasterMenuItem("Sites", "profile.png", Color.Orange, typeof(Sites)));
            items.Add(new MasterMenuItem("Alerts", "profile.png", Color.Orange, typeof(Alerts)));
            Listview.ItemsSource = items;

        }
    }
}
