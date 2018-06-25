using System;
using System.Collections.Generic;
using Brightwave2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Brightwave2.Views;

namespace Brightwave2.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            InitializeComponent();
            masterpage.Listview.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterMenuItem;
            if(item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterpage.Listview.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
