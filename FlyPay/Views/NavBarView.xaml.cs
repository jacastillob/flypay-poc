using System;
using FlyPay.Pages;
using Microsoft.Maui.Controls;

namespace FlyPay.Views
{
    public partial class NavBarView
    {
        string activeTab;

        public string ActiveTab
        {
            get
            {
                return activeTab;
            }
            set
            {
                activeTab = value;

                var target = activeTab;
                var homeImg = (target == "Home") ? "tab_home_on.png" : "tab_home.png";
                var favImg = (target == "Favorites") ? "tab_favorites_on.png" : "tab_favorites.png";
                var mapImg = (target == "Map") ? "tab_map_on.png" : "tab_map.png";
                var settingsImg = (target == "Settings") ? "tab_settings_on.png" : "tab_settings.png";

                HomeTab.Source = ImageSource.FromFile(homeImg);
                FavoritesTab.Source = ImageSource.FromFile(favImg);
                MapTab.Source = ImageSource.FromFile(mapImg);
                SettingsTab.Source = ImageSource.FromFile(settingsImg);
            }
        }

        public NavBarView()
        {
            InitializeComponent();
        }

        private void HomeTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new HomePage());
        }
        private void CompassTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new CheckOutCodePage());
        }
        private void FavoritesTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new SavedBrandsPage());
        }

        private void MapTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new TransactionsPage());
        }

        private void SettingsTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new AccountOverviewPage());
        }
    }
}