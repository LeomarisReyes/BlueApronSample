using System;
using Prism.Commands;
using Prism.Navigation;
using System.Threading.Tasks;

namespace BlueApronSample.ViewModels
{
    public class OnTheMenuViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand OpenServingPageCommand { get; set; }
        public DelegateCommand CloseWindowsCommand { get; set; }
     
        public OnTheMenuViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            OpenServingPageCommand = new DelegateCommand(async () => await OpenServingPage());
            CloseWindowsCommand = new DelegateCommand(async () => await CloseWindows());
  
        }
        async Task OpenServingPage()
        {
            await _navigationService.NavigateAsync(NavigationConstants.Serving);
        }
        async Task CloseWindows()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
