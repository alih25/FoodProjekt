namespace FoodProjekt;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel _viewModel;
   

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
		BindingContext=viewModel;
    }

    async void OnNearbyRestaurantsTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//nearby");
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        await _viewModel.InitializeAsync();
    }

}

