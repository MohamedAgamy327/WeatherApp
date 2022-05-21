using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace WeatherApp.ViewModels
{
    public class CityDetailsViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public CityDetailsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


    }
}
