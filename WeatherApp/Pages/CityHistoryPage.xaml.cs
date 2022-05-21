using System.Collections.Generic;
using WeatherApp.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace WeatherApp.Pages
{
    public sealed partial class CityHistoryPage : Page
    {

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    var parameter = e.Parameter as string;  // "My data"
        //    base.OnNavigatedTo(e);
        //}

        public CityHistoryPage()
        {
            InitializeComponent();

            List<City> cities = new List<City>();

            cities.Add(new City
            {
                Country="1",
                Name="London"
            });

            cities.Add(new City
            {
                Country = "2",
                Name = "Paris"
            });

            cities.Add(new City
            {
                Country = "3",
                Name = "Vienna"
            });

            CitiesListView.ItemsSource = cities;
        }

    }

}
