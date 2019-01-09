using System;
using Prism.Commands;
using Prism.Navigation;
using System.Threading.Tasks;

namespace BlueApronSample.ViewModels
{
    public class MenuDetailViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand OpenOrderSummaryCommand { get; set; }
      
        public MenuDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OpenOrderSummaryCommand = new DelegateCommand(async () => await OpenSummary());
        }
 
        async Task OpenSummary()
        {
            await _navigationService.NavigateAsync(NavigationConstants.OrderSummary);
        } 
    }
}
