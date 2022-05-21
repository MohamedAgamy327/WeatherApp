using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Initialize a new list of books
            List<Book> books = new List<Book>();

            // Add some items to collection
            books.Add(
                new Book(
                            "Professional C# 6 and .NET Core 1.0",
                            "Christian Nagel",
                            "$60.00",
                            "Assets/professional_c_sharp_6_and_dot_ner_core_1.jpeg"
                    )
                );

            books.Add(
                new Book(
                            "Beginning ASP.NET for Visual Studio 2015",
                            "William Penberthy",
                            "$45.00",
                            "Assets/beginning_asp_dot_net_for_visual_studio_2015.jpeg"
                    )
                );

            books.Add(
                new Book(
                            "C# 24-Hour Trainer, 2nd Edition",
                            "Rod Stephens",
                            "$45.00",
                            "Assets/c_sharp_24_hour_trainer_2nd_edition.jpeg"
                    )
                );

            books.Add(
                new Book(
                            "Professional Visual Studio 2015",
                            "Bruce Johnson",
                            "$60.00",
                            "Assets/professional_visual_studio_2015.jpeg"
                    )
                );

            // Specify the list view item source
        //    ListView1.ItemsSource = books;
        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the instance of ListView
            ListView listView = sender as ListView;

            // Get the ListView selected item as a Book
            Book selectedBook = listView.SelectedItem as Book;

            // Initialize a new message dialog
            MessageDialog dialog = new MessageDialog(
                "Selected : \n"
                + selectedBook.BookName + "\n"
                + selectedBook.Author + "\n"
                + selectedBook.Price
                );

            // Finally, display the selected item details on dialog
            dialog.ShowAsync();
        }
    }

    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

        public Book(string bookName, string author, string price, string image)
        {
            this.BookName = bookName;
            this.Author = author;
            this.Price = price;
            this.Image = image;
        }
    }
}
