using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace FlyPay.Pages
{

    public partial class CheckOutConfirmationPage : ContentPage
    {
        public CheckOutConfirmationPage()
        {
            InitializeComponent();
        }

        private void CloseBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new HomePage());
        }
        private void SaveBrandBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new SavedBrandsPage());
        }
        
    }
}