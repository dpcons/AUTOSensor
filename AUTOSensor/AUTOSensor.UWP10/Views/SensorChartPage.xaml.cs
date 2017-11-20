using System;

using AUTOSensor.UWP10.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AUTOSensor.UWP10.Views
{
    public sealed partial class SensorChartPage : Page
    {
        private SensorChartViewModel ViewModel
        {
            get { return DataContext as SensorChartViewModel; }
        }

        // TODO WTS: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public SensorChartPage()
        {
            InitializeComponent();
        }
    }
}
