using Image_Adding_Task.Commands;
using Image_Adding_Task.Models;
using Image_Adding_Task.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Image_Adding_Task.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            AddImageCommand = new(AddImage,(o)=>true);
            GalleryCommand = new(Gallerry);
        }


        public RelayCommand AddImageCommand { get; set; }
        public RelayCommand GalleryCommand { get; set; }

        public void AddImage(object? p)
        {
            PageController.Content = new AddImagePage();
        } 
        
        public void Gallerry(object? p)
        {
            PageController.Content = new GalleryPage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           Gallery.Images = JsonFileHandler.Read<ObservableCollection<string>>("gallery.json");
        }
    }
}
