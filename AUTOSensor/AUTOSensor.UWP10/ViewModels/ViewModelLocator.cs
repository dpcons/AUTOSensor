using System;

using AUTOSensor.UWP10.Services;
using AUTOSensor.UWP10.Views;

using GalaSoft.MvvmLight.Ioc;

using Microsoft.Practices.ServiceLocation;

namespace AUTOSensor.UWP10.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            Register<PivotViewModel, PivotPage>();
            Register<MainViewModel, MainPage>();
            Register<MediaPlayerViewModel, MediaPlayerPage>();
            Register<GridViewModel, GridPage>();
            Register<MainInfoViewModel, MainInfoPage>();
            Register<SensorChartViewModel, SensorChartPage>();
            Register<MapViewModel, MapPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public MapViewModel MapViewModel => ServiceLocator.Current.GetInstance<MapViewModel>();

        public SensorChartViewModel SensorChartViewModel => ServiceLocator.Current.GetInstance<SensorChartViewModel>();

        public MainInfoViewModel MainInfoViewModel => ServiceLocator.Current.GetInstance<MainInfoViewModel>();

        public GridViewModel GridViewModel => ServiceLocator.Current.GetInstance<GridViewModel>();

        public MediaPlayerViewModel MediaPlayerViewModel => ServiceLocator.Current.GetInstance<MediaPlayerViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public PivotViewModel PivotViewModel => ServiceLocator.Current.GetInstance<PivotViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
