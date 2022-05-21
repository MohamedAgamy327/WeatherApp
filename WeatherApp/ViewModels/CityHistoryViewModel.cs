using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.IServices;
using WeatherApp.Models;
using Windows.UI.Xaml.Navigation;

namespace WeatherApp.ViewModels
{
    public class CityHistoryViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IWeatherService _weatherService;

        public CityHistoryViewModel(
            INavigationService navigationService,
            IWeatherService weatherService)
        {
            _navigationService = navigationService;
            _weatherService = weatherService;

            _selectedCity = App.City;
            var task = _weatherService.GetAll(App.City);
            task.Wait();
            List<Weather> weathers = task.Result;
            _Weathers = new ObservableCollection<Weather>(weathers);
        }

        private string _selectedCity;
        public string SelectedCity
        {
            get { return _selectedCity; }
            set { Set(ref _selectedCity, value); }
        }

        private ObservableCollection<Weather> _Weathers;
        public ObservableCollection<Weather> Weathers
        {
            get { return _Weathers; }
            set { Set(ref _Weathers, value); }
        }


        private RelayCommand _navigateToMainView;
        public RelayCommand NavigateToMainView
        {
            get
            {
                return _navigateToMainView
                    ?? (_navigateToMainView = new RelayCommand(NavigateToMainViewMethod));
            }
        }
        private void NavigateToMainViewMethod()
        {
            _navigationService.GoBack();
        }

    }
}
