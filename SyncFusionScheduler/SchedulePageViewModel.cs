using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace SyncFusionScheduler
{
    public class SchedulePageViewModel: INotifyPropertyChanged
    {
        private Command visibleDatesChangedCommand;
        public Command VisibleDatesChangedCommand
        {
            get => visibleDatesChangedCommand;
            set
            {
                visibleDatesChangedCommand = value;
                OnPropertyChanged(nameof(VisibleDatesChangedCommand));
            }
        }

        private string onAppearingTime;
        public string OnAppearingTime
        {
            get => onAppearingTime;
            set
            {
                onAppearingTime = value;
                OnPropertyChanged(nameof(OnAppearingTime));
            }
        }

        private string afterRenderTime;
        public string AfterRenderTime
        {
            get => afterRenderTime;
            set
            {
                afterRenderTime = value;
                OnPropertyChanged(nameof(AfterRenderTime));
            }
        }

        public SchedulePageViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
