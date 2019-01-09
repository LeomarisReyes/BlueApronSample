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
      
        public OnTheMenuViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            OpenServingPageCommand = new DelegateCommand(async () => await OpenServingPage());
        }
        async Task OpenServingPage()
        {
            await _navigationService.NavigateAsync(NavigationConstants.Serving);
        }
    }
}
