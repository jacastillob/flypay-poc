using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace FlyPay.Pages
{

    public partial class DeliveryAddressPage : ContentPage
    {
        String source;
        public DeliveryAddressPage()
        {
            InitializeComponent();
        }

        public DeliveryAddressPage(String source)
        {
            InitializeComponent();
            this.source = source;
        }
        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            if (this.source == "home")
                (App.Current.MainPage as NavigationPage).PushAsync(new HomePage());
            if (this.source == "checkout")
                (App.Current.MainPage as NavigationPage).PushAsync(new CheckOutPage());
        }
    }
}