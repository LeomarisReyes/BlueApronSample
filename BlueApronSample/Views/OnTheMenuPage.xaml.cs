using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BlueApronSample.Views
{
    public partial class OnTheMenuPage : ContentPage
    {
        public OnTheMenuPage()
        {
            InitializeComponent();
        }

        void Date1_Tapped(object sender, EventArgs args)
        {
            Date1.FontAttributes = FontAttributes.Bold;
            Date2.FontAttributes = FontAttributes.None;
            Date3.FontAttributes = FontAttributes.None;
            Date4.FontAttributes = FontAttributes.None;
            //
            Date1.TextColor = Color.FromHex("#263266");
            Date2.TextColor = Color.FromHex("#3d3d3d");
            Date3.TextColor = Color.FromHex("#3d3d3d");
            Date4.TextColor = Color.FromHex("#3d3d3d");

        }

        void Date2_Tapped(object sender, EventArgs args)
        {
            Date1.FontAttributes = FontAttributes.None;
            Date2.FontAttributes = FontAttributes.Bold;
            Date3.FontAttributes = FontAttributes.None;
            Date4.FontAttributes = FontAttributes.None;
            //
            Date1.TextColor = Color.FromHex("#3d3d3d"); 
            Date2.TextColor = Color.FromHex("#263266");
            Date3.TextColor = Color.FromHex("#3d3d3d");
            Date4.TextColor = Color.FromHex("#3d3d3d"); 
        }

        void Date3_Tapped(object sender, EventArgs args)
        {
            Date1.FontAttributes = FontAttributes.None;
            Date2.FontAttributes = FontAttributes.None;
            Date3.FontAttributes = FontAttributes.Bold;
            Date4.FontAttributes = FontAttributes.None;
            //
            Date1.TextColor = Color.FromHex("#3d3d3d");
            Date2.TextColor = Color.FromHex("#3d3d3d");
            Date3.TextColor = Color.FromHex("#263266"); 
            Date4.TextColor = Color.FromHex("#3d3d3d"); 
        }

        void Date4_Tapped(object sender, EventArgs args)
        {
            Date1.FontAttributes = FontAttributes.None;
            Date2.FontAttributes = FontAttributes.None;
            Date3.FontAttributes = FontAttributes.None;
            Date4.FontAttributes = FontAttributes.Bold;
            //
            Date1.TextColor = Color.FromHex("#3d3d3d");
            Date2.TextColor = Color.FromHex("#3d3d3d");
            Date3.TextColor = Color.FromHex("#3d3d3d");
            Date4.TextColor = Color.FromHex("#263266");  
        }
    }
}
