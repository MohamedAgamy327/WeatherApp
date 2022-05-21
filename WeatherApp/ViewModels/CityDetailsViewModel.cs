using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Threading.Tasks;
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

       
        private RelayCommand _load;
        public RelayCommand Load
        {
            get
            {
                return _load
                    ?? (_load = new RelayCommand(ExecuteLoadAsync));
            }
        }
        private async void ExecuteLoadAsync()
        {
        CurrentWeather = await _weatherService.GetCurrent(App.City).ConfigureAwait(true);
        }

    }
}
