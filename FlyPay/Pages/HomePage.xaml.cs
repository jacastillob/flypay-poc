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
    public partial class HomePage : ContentPage
    {
        static bool isSetup = false;

        public HomePage()
        {
            InitializeComponent();

            //NavBar.ActiveTab = "Home";

            if (!isSetup)
            {
                isSetup = true;

              //  SetupAppActions();
              //  SetupTrayIcon();
            }
         

//#if WINDOWS
//            MauiWinUIApplication.Current.MainWindow.Title = "Weather TwentyOne";
//            MauiWinUIApplication.Current.MainWindow.SetIcon("Resources/trayicon.ico");
//#endif
        }

        private void LblClickEditCard()
        {
        }
        
        public void CardBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new CardPage("home"));
        }
        public void FlyBuysBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new FlyBuysPage("home"));
        }
        public void AddressBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new DeliveryAddressPage("home"));
        }

        private void PaymentBtn_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new PaymentCodePage());
        }

        private void SetupAppActions()
        {
            try
            {
#if WINDOWS
                AppActions.IconDirectory = Application.Current.On<WindowsConfiguration>().GetImageDirectory();
#endif

                AppActions.SetAsync(
                    new AppAction("current_info", "Check Current Weather", icon: "current_info"),
                    new AppAction("add_location", "Add a Location", icon: "add_location")
                );
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine("App Actions not supported", ex);
            }
        }

        private void SetupTrayIcon()
        {
            var trayService = ServiceProvider.GetService<ITrayService>();

            if (trayService != null)
            {
                trayService.Initialize();
                trayService.ClickHandler = () =>
                    ServiceProvider.GetService<INotificationService>()
                        ?.ShowNotification("Hello Build! 😻 From .NET MAUI", "How's your weather?  It's sunny where we are 🌞");
            }
        }
    }
}
