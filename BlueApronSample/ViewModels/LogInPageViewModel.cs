using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace BlueApronSample.ViewModels
{
    public class LogInPageViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand OpenSignUpCommand { get; set; }
        public DelegateCommand OpenMenuCommand   { get; set; }
        public DelegateCommand CloseWindowsCommand { get; set; }

        public LogInPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            OpenSignUpCommand = new DelegateCommand(async () => await OpenSignUp());
            OpenMenuCommand = new DelegateCommand(async () => await OpenMenu());
            CloseWindowsCommand = new DelegateCommand(async () => await CloseWindows());
        }

        async Task OpenSignUp()
        {
            await _navigationService.NavigateAsync(NavigationConstants.SignUp);
        }

        async Task OpenMenu()
        {
            await _navigationService.NavigateAsync(NavigationConstants.TabPOrdenSummary);
        }

        async Task CloseWindows()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
