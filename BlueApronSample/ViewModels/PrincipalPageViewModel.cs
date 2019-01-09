using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace BlueApronSample.ViewModels
{
    public class PrincipalPageViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand OpenLoginCommand { get; set; }
        public DelegateCommand OpenMenuCommand { get; set; }

        public PrincipalPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            OpenLoginCommand = new DelegateCommand(async () => await OpenLogin());
            OpenMenuCommand  = new DelegateCommand(async () => await OpenFreeMenu());
        }

        async Task OpenLogin()
        {
            await _navigationService.NavigateAsync(NavigationConstants.LogIn, null, true);
        }
        async Task OpenFreeMenu()
        {
            await _navigationService.NavigateAsync(NavigationConstants.TabPGetStarted);
        }
    }
}
