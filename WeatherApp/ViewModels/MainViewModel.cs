using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace WeatherApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SelectedFeedItem = "Mido";
        }

        private string _selectedFeedItem;

        public string SelectedFeedItem
        {
            get { return _selectedFeedItem; }
            set { Set(ref _selectedFeedItem, value); }
        }


        private RelayCommand<string> _navigateToView;
        public RelayCommand<string> NavigateToView
        {
            get
            {
                return _navigateToView
                    ?? (_navigateToView = new RelayCommand<string>(NavigateToViewMethodAsync));
            }
        }
        private void NavigateToViewMethodAsync(string destination)
        {
            switch (destination)
            {
                case "History":
                    App.city = "ssss";
                    _navigationService.NavigateTo("CityHistoryPage");
                    break;
                case "Details":
                    _navigationService.NavigateTo("SecondPage");

                    break;
                default:
                    break;
            }
        }
    }
}
