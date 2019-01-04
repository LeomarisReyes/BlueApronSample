using System.ComponentModel;
using BlueApronSample.Models;
using Xamarin.Forms;

namespace BlueApronSample.ViewModels
{
    public class ServingViewModel : INotifyPropertyChanged
    {
        public bool IsVisible { get; set; } = false;
        public Command ChangeVisibiliyCommand { get; set; }

        public ServingViewModel()
        {
            ChangeVisibiliyCommand = new Command(ChangeVisibiliy);
        }

        public void ChangeVisibiliy()
        {
            IsVisible = !IsVisible;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}