﻿using System.Collections.Generic;
using WeatherApp.Models;
using Windows.UI.Xaml.Controls;


namespace WeatherApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            List<City> cities = new List<City>();

            cities.Add(new City
            {
                Country="UK",
                Name="London"
            });

            cities.Add(new City
            {
                Country = "FR",
                Name = "Paris"
            });

            cities.Add(new City
            {
                Country = "AUT",
                Name = "Vienna"
            });

            CitiesListView.ItemsSource = cities;
        }

    }

}
