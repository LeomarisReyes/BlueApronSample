using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BlueApronSample.Views
{
    public partial class ServingPage : ContentPage
    { 
        public ServingPage()
        {
            InitializeComponent();
            PriceList.IsVisible = false;
        }

        void Circle1_Tapped(object sender, EventArgs args)
        { 
            if (!imgCircle1.Source.ToString().Contains("Green"))
            {
                imgCircle1.Source = "GreenCircle";
                imgCircle2.Source = "Circle";
                imgCircle3.Source = "Circle";
                Time1.ForegroundColor = Color.FromHex("#07aa79");
                Time2.ForegroundColor = Color.FromHex("#33507b");
                Time3.ForegroundColor = Color.FromHex("#33507b");
            }
            else
            {
                imgCircle1.Source = "Circle";
                Time1.ForegroundColor = Color.FromHex("#33507b"); 
            } 
            PriceList.IsVisible = !PriceList.IsVisible;
        }

        void Circle2_Tapped(object sender, EventArgs args)
        {
               
            if (!imgCircle2.Source.ToString().Contains("Green"))
            {
                imgCircle1.Source = "Circle";
                imgCircle2.Source = "GreenCircle";
                imgCircle3.Source = "Circle";
                Time1.ForegroundColor = Color.FromHex("#33507b");
                Time2.ForegroundColor = Color.FromHex("#07aa79");
                Time3.ForegroundColor = Color.FromHex("#33507b"); 
            }
            else
            {
                imgCircle2.Source = "Circle";
                Time2.ForegroundColor = Color.FromHex("#33507b"); 
            }
            PriceList.IsVisible = !PriceList.IsVisible;

        }

        void Circle3_Tapped(object sender, EventArgs args)
        {
           
            if (!imgCircle3.Source.ToString().Contains("Green"))
            {
                imgCircle1.Source = "Circle";
                imgCircle2.Source = "Circle";
                imgCircle3.Source = "GreenCircle";
                Time1.ForegroundColor = Color.FromHex("#33507b");
                Time2.ForegroundColor = Color.FromHex("#33507b");
                Time3.ForegroundColor = Color.FromHex("#07aa79"); 
            }
                else
            {
                imgCircle3.Source = "Circle";
                Time3.ForegroundColor = Color.FromHex("#33507b"); 
            }

            PriceList.IsVisible = !PriceList.IsVisible;

        }
 
    }
}
