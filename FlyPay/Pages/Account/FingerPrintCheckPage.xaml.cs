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
    public partial class FingerPrintCheckPage : ContentPage
    {
        String source;
        public FingerPrintCheckPage()
        {
            InitializeComponent();
        }
        public FingerPrintCheckPage(string source)
        {
            InitializeComponent();
            this.source = source;
        }
        private void ContinueBtn_Clicked(object sender, EventArgs e)
        {
            if (this.source == "payment")
                (App.Current.MainPage as NavigationPage).PushAsync(new CheckOutConfirmationPage());
            if (this.source == "checkout")
                (App.Current.MainPage as NavigationPage).PushAsync(new CheckOutConfirmationPage());
            
        }
    }
}

