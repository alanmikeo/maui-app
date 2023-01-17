using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using UraniumUI;

namespace MauiAppOne;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddMaterialIconFonts();
			}).ConfigureMauiHandlers(handlers =>
            {
                handlers.AddUraniumUIHandlers(); // 👈 This line should be added.
            }); ;

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
