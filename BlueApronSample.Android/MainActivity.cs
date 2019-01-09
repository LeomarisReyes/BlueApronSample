using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace BlueApronSample.Droid
{
    [Activity(Label = "BlueApronSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        public class AndroidInitializer : IPlatformInitializer
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
                containerRegistry.RegisterForNavigation<Views.PrincipalPage,ViewModels.PrincipalPageViewModel>();
                containerRegistry.RegisterForNavigation<Views.ProfilePage , ViewModels.ProfileViewModel>();
                containerRegistry.RegisterForNavigation<Views.SignUpPage, ViewModels.SignUpViewModel>();
                containerRegistry.RegisterForNavigation<Views.TabPOrdenSummary>();
                containerRegistry.RegisterForNavigation<Views.TabPGetStartedPage>();
                containerRegistry.RegisterForNavigation<Views.RecipesPage, ViewModels.RecipesViewModel>();
                containerRegistry.RegisterForNavigation<Views.ServingPage, ViewModels.ServingViewModel>();
            }
        }
    }
}

