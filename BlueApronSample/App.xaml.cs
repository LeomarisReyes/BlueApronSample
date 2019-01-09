using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BlueApronSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer){}

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync(NavigationConstants.TabPOrdenSummary);
         }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Views.DataDeliverPage, ViewModels.DataDeliverViewModel>();
            containerRegistry.RegisterForNavigation<Views.LogInPage,ViewModels.LogInPageViewModel>();
            containerRegistry.RegisterForNavigation<Views.MenuDetailPage, ViewModels.MenuDetailViewModel>();
            containerRegistry.RegisterForNavigation<Views.OnTheMenuPage, ViewModels.OnTheMenuViewModel>();
            containerRegistry.RegisterForNavigation<Views.OrderSummaryPage, ViewModels.OrderSummaryViewModel>();
            containerRegistry.RegisterForNavigation<Views.PlanPage, ViewModels.PlanViewModel>();
            containerRegistry.RegisterForNavigation<Views.PrincipalPage,ViewModels.PrincipalPageViewModel>();
            containerRegistry.RegisterForNavigation<Views.ProfilePage, ViewModels.ProfileViewModel>();
            containerRegistry.RegisterForNavigation<Views.SignUpPage,ViewModels.SignUpViewModel>();
            containerRegistry.RegisterForNavigation<Views.TabPOrdenSummary>();
            containerRegistry.RegisterForNavigation<Views.TabPGetStartedPage>();
            containerRegistry.RegisterForNavigation<Views.RecipesPage, ViewModels.RecipesViewModel>();
            containerRegistry.RegisterForNavigation<Views.ServingPage, ViewModels.ServingViewModel>();

        } 
    }
}
