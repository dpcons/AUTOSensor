using System;

using AUTOSensor.UWP10.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AUTOSensor.UWP10.Views
{
    public sealed partial class SettingsPage : Page
    {
        private SettingsViewModel ViewModel
        {
            get { return DataContext as SettingsViewModel; }
        }

        //// TODO WTS: Change the URL for your privacy policy in the Resource File, currently set to https://YourPrivacyUrlGoesHere

        public SettingsPage()
        {
            InitializeComponent();
            ViewModel.Initialize();
        }
    }
}
