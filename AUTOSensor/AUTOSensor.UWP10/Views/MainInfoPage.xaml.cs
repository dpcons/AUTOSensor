using System;

using AUTOSensor.UWP10.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AUTOSensor.UWP10.Views
{
    public sealed partial class MainInfoPage : Page
    {
        private MainInfoViewModel ViewModel
        {
            get { return DataContext as MainInfoViewModel; }
        }

        public MainInfoPage()
        {
            InitializeComponent();
        }
    }
}
