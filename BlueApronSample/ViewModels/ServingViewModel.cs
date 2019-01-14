using System.ComponentModel;
using System.Threading.Tasks;
using BlueApronSample.Models;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace BlueApronSample.ViewModels
{
    public class ServingViewModel : INotifyPropertyChanged
    {
        INavigationService _navigationService; 
        public bool IsVisible { get; set; } = false;
        public DelegateCommand ChangeVisibiliyCommand { get; set; }
        public DelegateCommand OpenDataDeliverCommand { get; set; }
        public DelegateCommand CloseWindowsCommand { get; set; }
      

        public ServingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            OpenDataDeliverCommand = new DelegateCommand(async () => await OpenDataDeliver());
            CloseWindowsCommand = new DelegateCommand(async () => await CloseWindows());
        }
         
        async Task OpenDataDeliver()
        {
            await _navigationService.NavigateAsync(NavigationConstants.DataDeliver);
        }

        async Task CloseWindows()
        {
            await _navigationService.GoBackAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}