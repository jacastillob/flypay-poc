using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using FlyPay.Services;


namespace FlyPay
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				 .ConfigureServices(services => {
#if WINDOWS
                    services.AddSingleton<ITrayService, WinUI.TrayService>();
                    services.AddSingleton<INotificationService, WinUI.NotificationService>();
#elif MACCATALYST
                    services.AddSingleton<ITrayService, MacCatalyst.TrayService>();
                    services.AddSingleton<INotificationService, MacCatalyst.NotificationService>();
#endif
				 })
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});
		}
	}
}