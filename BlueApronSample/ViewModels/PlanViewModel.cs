using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace BlueApronSample.ViewModels
{
    public class PlanViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand CloseWindowsCommand { get; set; }
      
        public PlanViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            CloseWindowsCommand = new DelegateCommand(async () => await CloseWindows());
        }

        async Task CloseWindows()
        {
            _navigationService.GoBackAsync();
        }
    }
}
