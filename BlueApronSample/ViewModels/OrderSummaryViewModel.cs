using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace BlueApronSample.ViewModels
{
    public class OrderSummaryViewModel
    {
        INavigationService _navigationService; 
        public DelegateCommand CloseWindowsCommand { get; set; }
        public DelegateCommand OpenPlansCommand { get; set; }
        public DelegateCommand OpenCompletedOrdersCommand { get; set; }

        public OrderSummaryViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            CloseWindowsCommand = new DelegateCommand(async () => await CloseWindows());
            OpenPlansCommand = new DelegateCommand(async () => await OpenPlans());
            OpenCompletedOrdersCommand = new DelegateCommand(async () => await OpenCompletedOrders());
        }

        async Task CloseWindows()
        {
            await _navigationService.GoBackAsync();
        }

        async Task OpenPlans()
        {
            await _navigationService.NavigateAsync(NavigationConstants.PlanPage);
        }

        async Task OpenCompletedOrders()
        {
            await _navigationService.NavigateAsync(NavigationConstants.TabPOrdenSummary);
        }

    }
}
