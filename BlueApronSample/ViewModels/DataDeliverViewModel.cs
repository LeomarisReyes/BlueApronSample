using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace BlueApronSample.ViewModels
{
    public class DataDeliverViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand OpenDetailCommand { get; set; }
        public DelegateCommand CloseWindowsCommand { get; set; }

        public DataDeliverViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OpenDetailCommand = new DelegateCommand(async () => await OpenDetail());
            CloseWindowsCommand = new DelegateCommand(async () => await CloseWindows());
        }

        async Task OpenDetail()
        {
            await _navigationService.NavigateAsync(NavigationConstants.OrderSummary);
        }

        async Task CloseWindows()
        {
            _navigationService.GoBackAsync();
        }

    }
}
