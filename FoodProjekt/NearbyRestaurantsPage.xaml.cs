namespace FoodProjekt;

public partial class NearbyRestaurantsPage : ContentPage
{
	public NearbyRestaurantsPage(NearbyrestaurantsView nearbyrestaurantsView)
	{
       
        InitializeComponent();
        BindingContext = nearbyrestaurantsView;

    }

   
}
