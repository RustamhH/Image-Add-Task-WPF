﻿using Image_Adding_Task.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Image_Adding_Task.Views
{
    /// <summary>
    /// Interaction logic for AddImagePage.xaml
    /// </summary>
    public partial class AddImagePage : Page
    {
        public AddImagePage()
        {
            InitializeComponent();
            DataContext = new AddImageViewModel();
        }
    }
}
