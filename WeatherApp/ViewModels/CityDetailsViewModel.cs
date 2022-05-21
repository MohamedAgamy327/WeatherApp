using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using WeatherApp.IServices;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class CityDetailsViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IWeatherService _weatherService;

        public CityDetailsViewModel(
            INavigationService navigationService,
            IWeatherService weatherService)
        {
            _navigationService = navigationService;
            _weatherService = weatherService;

            var task = _weatherService.GetCurrent(App.City);
            task.Wait();
            _currentWeather = task.Result;
        }

        private Weather _currentWeather;
        public Weather CurrentWeather
        {
            get { return _currentWeather; }
            set { Set(ref _currentWeather, value); }
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
