using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("RobotoSlab-Black.ttf", "RobotoSlabBlack");
                    fonts.AddFont("RobotoSlab-Bold.ttf", "RobotoSlabBold");
                    fonts.AddFont("RobotoSlab-Medium.ttf", "RobotoSlabMedium");
                    fonts.AddFont("RobotoSlab-Regular.ttf", "RobotoSlabRegular");
                    fonts.AddFont("RobotoSlab-Semibold.ttf", "RobotoSlabSemibold");


                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
