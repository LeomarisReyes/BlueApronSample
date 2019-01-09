using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Prism;
using Prism.Ioc;
using UIKit;
using Xamarin.Forms;

namespace BlueApronSample.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }

        public class iOSInitializer : IPlatformInitializer
        {
            public void RegisterTypes(IContainerRegistry containerRegistry)
            {
                containerRegistry.RegisterForNavigation<NavigationPage>();
                containerRegistry.RegisterForNavigation<Views.DataDeliverPage, ViewModels.DataDeliverViewModel>();
                containerRegistry.RegisterForNavigation<Views.LogInPage,ViewModels.LogInPageViewModel>();
                containerRegistry.RegisterForNavigation<Views.MenuDetailPage, ViewModels.MenuDetailViewModel>();
                containerRegistry.RegisterForNavigation<Views.OnTheMenuPage, ViewModels.OnTheMenuViewModel>();
                containerRegistry.RegisterForNavigation<Views.OrderSummaryPage , ViewModels.OrderSummaryViewModel>();
                containerRegistry.RegisterForNavigation<Views.PlanPage, ViewModels.PlanViewModel>();
                containerRegistry.RegisterForNavigation<Views.PrincipalPage, ViewModels.PrincipalPageViewModel>();
                containerRegistry.RegisterForNavigation<Views.ProfilePage, ViewModels.ProfileViewModel>();
                containerRegistry.RegisterForNavigation<Views.SignUpPage , ViewModels.SignUpViewModel>();
                containerRegistry.RegisterForNavigation<Views.TabPOrdenSummary>();
                containerRegistry.RegisterForNavigation<Views.TabPGetStartedPage>();
                containerRegistry.RegisterForNavigation<Views.RecipesPage, ViewModels.RecipesViewModel>();
                containerRegistry.RegisterForNavigation<Views.ServingPage, ViewModels.ServingViewModel>();

            }
        }
    }
}
