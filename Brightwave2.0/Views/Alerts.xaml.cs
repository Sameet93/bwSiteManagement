using System;
using System.Collections.Generic;
using Brightwave2.Models;
using Xamarin.Forms;

namespace Brightwave2.Views
{
    public partial class Alerts : ContentPage
    {
        public ListView ListView { get { return listview; }}
        public List<AlertTableItem> items;
        public Alerts()
        {
            InitializeComponent();
            Init();
            SetItems();
        }

        void Init()
        {
            listview.SeparatorColor = Color.Orange;
           
        }

        void SetItems()
        {
            items = new List<AlertTableItem>();
            items.Add(new AlertTableItem("Site", "Coordinates", "Type", "Status"));
            items.Add(new AlertTableItem("Musi", "41 24.2028, 2 10.4418", "HS", "Offline"));
            ListView.ItemsSource = items;
            ListView.ItemTapped += ListView_ItemTapped;


        }


        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
                if (Device.RuntimePlatform == Device.Android)
                {
                Application.Current.MainPage = new NavigationPage(new Report());
                }
                else if (Device.RuntimePlatform == Device.iOS)
                {
                await Navigation.PushAsync(new NavigationPage(new Report()));
                }


        }



    }
}
