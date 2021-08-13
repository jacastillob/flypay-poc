using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;


namespace FlyPay.Pages
{
   
    public partial class AccountOverviewPage : ContentPage
    {
        public AccountOverviewPage()
        {
            InitializeComponent();
        }
        public void ContactDetailsBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new ContactDetailsPage());
        }
        public void DigitalPreferencesBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new DigitalReceiptsPreferencesPage());
        }
        
    }
}