using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace SyncFusionScheduler
{
    public partial class SchedulePage : ContentPage
    {
        SchedulePageViewModel ViewModel;

        Stopwatch stopwatch = Stopwatch.StartNew();

        public SchedulePage()
        {
            BindingContext = ViewModel = new SchedulePageViewModel();

            InitializeComponent();

            ViewModel.VisibleDatesChangedCommand = new Command(DatesChanged);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ViewModel.OnAppearingTime = stopwatch.ElapsedMilliseconds.ToString();
        }

        public void DatesChanged()
        {
            stopwatch.Stop();

            ViewModel.AfterRenderTime = stopwatch.ElapsedMilliseconds.ToString();
        }
    }
}
