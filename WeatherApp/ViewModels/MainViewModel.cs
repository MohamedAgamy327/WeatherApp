using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WeatherApp.IServices;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly ICityService _cityService;

        public MainViewModel(
            INavigationService navigationService,
            ICityService cityService)
        {
            _navigationService = navigationService;
            _cityService = cityService;

            var task = _cityService.GetAll();
            task.Wait();
            List<City> cities = task.Result;
            Cities = new ObservableCollection<City>(cities);
        }

        private ObservableCollection<City> _cities;
        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set { Set(ref _cities, value); }
        }

        private City _selectedCity;
        public City SelectedCity
        {
            get { return _selectedCity; }
            set { Set(ref _selectedCity, value); }
        }


        private RelayCommand _navigateToAddView;
        public RelayCommand NavigateToAddView
        {
            get
            {
                return _navigateToAddView
                    ?? (_navigateToAddView = new RelayCommand(NavigateToAddViewMethod));
            }
        }
        private void NavigateToAddViewMethod()
        {
            _navigationService.NavigateTo("AddCityPage");
        }

        private RelayCommand<string> _navigateToDetailsView;
        public RelayCommand<string> NavigateToDetailsView
        {
            get
            {
                return _navigateToDetailsView
                    ?? (_navigateToDetailsView = new RelayCommand<string>(NavigateToDetailsViewMethod));
            }
        }
        private void NavigateToDetailsViewMethod(string city)
        {
            App.City = city;
            _navigationService.NavigateTo("CityDetailsPage");
        }

        private RelayCommand<string> _navigateToHistoryView;
        public RelayCommand<string> NavigateToHistoryView
        {
            get
            {
                return _navigateToHistoryView
                    ?? (_navigateToHistoryView = new RelayCommand<string>(NavigateToHistoryViewMethod));
            }
        }
        private void NavigateToHistoryViewMethod(string city)
        {
            App.City = city;
            _navigationService.NavigateTo("CityHistoryPage");
        }
    }
}
