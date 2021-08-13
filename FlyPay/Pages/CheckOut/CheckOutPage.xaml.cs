using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Essentials;
using Application = Microsoft.Maui.Controls.Application;
using WindowsConfiguration = Microsoft.Maui.Controls.PlatformConfiguration.Windows;
using FlyPay.Services;

namespace FlyPay.Pages
{
    public partial class CheckOutPage : ContentPage
    {
        public CheckOutPage()
        {
            InitializeComponent();

        }
        private void PayNowBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new FingerPrintCheckPage("checkout"));
        }
        public void CardBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new CardPage("checkout"));
        }
        public void FlyBuysBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new FlyBuysPage("checkout"));
        }
        public void AddressBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new DeliveryAddressPage("checkout"));
        }

    }
}

