
using Windows.UI.Xaml.Controls;

using System.Windows.Input;


namespace WeatherApp.Pages
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void MyListView_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    HitTestResult r = VisualTreeHelper.HitTest(this, e.GetPosition(this));
        //    if (r.VisualHit.GetType() != typeof(ListBoxItem))
        //        listView1.UnselectAll();
        //}
    }

}
