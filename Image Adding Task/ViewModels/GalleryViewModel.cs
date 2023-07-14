using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Image_Adding_Task.ViewModels
{
    public class GalleryViewModel
    {
        public GalleryViewModel()
        {
            foreach (var item in Images)
            {
                BitImages.Add(new() { Source = new BitmapImage(new Uri(item)) ,Height=100,Width=100});
            }
        }

        public ObservableCollection<string> Images { get; set; } = Gallery.Images;
        public ObservableCollection<Image> BitImages { get; set; }=new();



        
    }
}
