using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace BlueApronSample.ViewModels
{
    public class SignUpViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand OpenLoginCommand { get; set; }
        public DelegateCommand CloseWindowsCommand { get; set; }

        public SignUpViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OpenLoginCommand = new DelegateCommand(async () => await OpenLogin());
            CloseWindowsCommand = new DelegateCommand(async () => await CloseWindows());
        }

        async Task OpenLogin()
        {
            await _navigationService.NavigateAsync(NavigationConstants.LogIn);
        }

        async Task CloseWindows()
        {
            _navigationService.GoBackAsync();
        }
    }
}
