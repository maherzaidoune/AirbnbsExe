using AirbnbsExe.model;
using AirbnbsExe.service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirbnbsExe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Airbnb : ContentPage
	{
        ObservableCollection<Search>  search ;
        SearchService service;
		public Airbnb ()
		{
            InitializeComponent();
            service =   new SearchService();
            search = new ObservableCollection<Search>(service.GetSearch());
            listView.ItemsSource = search;
        }

        public void delete(Object source, EventArgs e)
        {
            var menuItem = source as MenuItem;

            var search = menuItem.CommandParameter as Search;
            service.deleteSearch(search.id);
            listView.ItemsSource = service.GetSearch();
        }
        public void refresh(Object sender , EventArgs e)
        {
            listView.ItemsSource = service.GetSearch();
            listView.EndRefresh();
        }
        public void serching(Object sender,TextChangedEventArgs e)
        {
            listView.ItemsSource =  service.GetSearch(e.NewTextValue);
        }

    }
}