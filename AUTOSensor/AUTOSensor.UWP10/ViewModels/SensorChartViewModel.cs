using System;
using System.Collections.ObjectModel;

using AUTOSensor.UWP10.Models;
using AUTOSensor.UWP10.Services;

using GalaSoft.MvvmLight;

namespace AUTOSensor.UWP10.ViewModels
{
    public class SensorChartViewModel : ViewModelBase
    {
        public SensorChartViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
