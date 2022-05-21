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
    public class CityHistoryViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public CityHistoryViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


    }
}
