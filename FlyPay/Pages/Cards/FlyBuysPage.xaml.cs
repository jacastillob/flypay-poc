using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace FlyPay.Pages
{

    public partial class FlyBuysPage : ContentPage
    {
        String source;
        public FlyBuysPage()
        {
            InitializeComponent();
        }
        public FlyBuysPage(String source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void FlyBuysBtn_Clicked(object sender, EventArgs e)
        {
            if (this.source == "home")
                (App.Current.MainPage as NavigationPage).PushAsync(new HomePage());
            if (this.source == "checkout")
                (App.Current.MainPage as NavigationPage).PushAsync(new CheckOutPage());
        }

    }
}