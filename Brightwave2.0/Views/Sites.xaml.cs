using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.Http;
using Brightwave2.Models;
using Xamarin.Forms;


namespace Brightwave2.Views
{
    public partial class Sites : ContentPage
    {
        public ListView ListView { get { return listview; }}
        public List<SiteTableItem> items;
        public Sites()
        {
            InitializeComponent();
            Init();
            SetItems();
        }

        void Init()
        {
            listview.SeparatorColor = Color.Orange;

        }


        public void SetItems()
        {
            
           
            items = new List<SiteTableItem>();
            items.Add(new SiteTableItem("Site", "Coordinates", "Status", "Type"));
            SqlConnection();
            ListView.ItemsSource = items;
            ListView.ItemTapped += ListView_ItemTapped;

        }

        public void SqlConnection()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                client.BaseAddress = new   
                Uri("https://brightwaveapi.azurewebsites.net");
                }   
            }catch(Exception e)
            {
                DisplayAlert("Failure", "Failed to Conect", "Ok");
            }

        }

        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                Application.Current.MainPage = new NavigationPage(new SiteDetails());
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                await Navigation.PushAsync(new NavigationPage(new SiteDetails()));
            }
        }
    }
}
