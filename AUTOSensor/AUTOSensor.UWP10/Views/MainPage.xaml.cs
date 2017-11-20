using System;

using AUTOSensor.UWP10.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AUTOSensor.UWP10.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
