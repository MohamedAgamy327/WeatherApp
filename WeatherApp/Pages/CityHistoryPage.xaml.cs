using System.Collections.Generic;
using WeatherApp.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace WeatherApp.Pages
{
    public sealed partial class CityHistoryPage : Page
    {
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
