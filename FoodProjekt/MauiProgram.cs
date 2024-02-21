namespace FoodProjekt;

public static class MauiProgram
{

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})

			

            .UseMauiCommunityToolkit();

		builder.Services.AddHttpClient(AppConstants.ApiHttpClientName, httpClient =>
		{
			httpClient.BaseAddress = new Uri("https://localhost:7075/api/Categories");

        });



		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IMap>(Map.Default);
		builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<NearbyrestaurantsView>();
        builder.Services.AddSingleton<NearbyRestaurantsPage>();
        return builder.Build();
	}
}
