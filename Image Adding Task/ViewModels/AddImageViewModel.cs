using Image_Adding_Task.Commands;
using Image_Adding_Task.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Image_Adding_Task.ViewModels
{

    public static class Gallery
    {
        public static ObservableCollection<string> Images { get; set; } = new();
    }


    public class AddImageViewModel:INotifyPropertyChanged
    {
        public RelayCommand FileDialogCommand { get; set; }

        private string filepath;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnProperty([CallerMemberName] string? name = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public string FilePath
        {
            get { return filepath; }
            set { filepath = value;OnProperty(); }
        }





        public AddImageViewModel()
        {
            FileDialogCommand = new(Add);
        }

        public void Add(object?param)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
            
            if (fileDialog.ShowDialog()==true)
            {

                FilePath= fileDialog.FileName;
                var image = fileDialog.FileName;

                Gallery.Images.Add(image);

                JsonFileHandler.Write("gallery.json", Gallery.Images);
            }
        }

    }
}
