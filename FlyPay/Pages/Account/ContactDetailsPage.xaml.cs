using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace FlyPay.Pages
{
    public partial class ContactDetailsPage : ContentPage
    {
        
        public ContactDetailsPage()
        {
            InitializeComponent();
        }
        private void SaveBtn_Clicked(object sender, EventArgs e)
        {

            (App.Current.MainPage as NavigationPage).PushAsync(new AccountOverviewPage());
        }
            
    }
}