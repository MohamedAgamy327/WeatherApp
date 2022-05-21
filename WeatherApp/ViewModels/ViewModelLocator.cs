
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using WeatherApp.Pages;

namespace WeatherApp.ViewModels
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        /// 
        public const string MainPageKey = "MainPage";
        public const string CityHistoryPageKey = "CityHistoryPage";
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var nav = new NavigationService();
            nav.Configure(MainPageKey, typeof(MainPage));
            nav.Configure(CityHistoryPageKey, typeof(CityHistoryPage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);


            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CityHistoryViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public CityHistoryViewModel CityHistory => ServiceLocator.Current.GetInstance<CityHistoryViewModel>();
    }
}
