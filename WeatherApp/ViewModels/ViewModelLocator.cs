
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using WeatherApp.IServices;
using WeatherApp.Pages;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class ViewModelLocator
    {
        public const string MainPageKey = "MainPage";
        public const string CityHistoryPageKey = "CityHistoryPage";
        public const string CityDetailsPageKey = "CityDetailsPage";
        public const string AddCityPageKey = "AddCityPage";
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var nav = new NavigationService();
            nav.Configure(MainPageKey, typeof(MainPage));
            nav.Configure(CityHistoryPageKey, typeof(CityHistoryPage));
            nav.Configure(AddCityPageKey, typeof(AddCityPage));
            nav.Configure(CityDetailsPageKey, typeof(CityDetailsPage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);

            SimpleIoc.Default.Register<ICityService, CityService>();
            SimpleIoc.Default.Register<IWeatherService, WeatherService>();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CityHistoryViewModel>();
            SimpleIoc.Default.Register<AddCityViewModel>();
            SimpleIoc.Default.Register<CityDetailsViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public CityHistoryViewModel CityHistory => ServiceLocator.Current.GetInstance<CityHistoryViewModel>();
        public CityDetailsViewModel CityDetails => ServiceLocator.Current.GetInstance<CityDetailsViewModel>();
        public AddCityViewModel AddCity => ServiceLocator.Current.GetInstance<AddCityViewModel>();
    }
}
