namespace FoodProjekt;

public partial class App : Application
{
    //public static string BaseUrl { get; internal set; } = @"https://10.0.2.2:7075/api/Categories";
    public static string BaseUrl { get; internal set; } = @"https://localhost:7075/api/Categories";

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
