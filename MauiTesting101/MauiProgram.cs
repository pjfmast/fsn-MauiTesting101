using Microsoft.Extensions.Logging;
using MauiTesting101.ViewModels;

namespace MauiTesting101
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            // register ViewModels:
            builder.Services.AddSingleton<MainPageViewModel>();

            // register Pages:
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
