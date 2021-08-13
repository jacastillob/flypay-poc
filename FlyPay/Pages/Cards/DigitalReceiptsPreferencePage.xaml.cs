using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace FlyPay.Pages
{
    public partial class DigitalReceiptsPreferencesPage : ContentPage
    {
        public DigitalReceiptsPreferencesPage()
        {
            InitializeComponent();
        }
        private void DoneBtn_Clicked(object sender, EventArgs e)
        {
          (App.Current.MainPage as NavigationPage).PushAsync(new AccountOverviewPage());
        }

    }
}