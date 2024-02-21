using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjekt.ViewModels
{
    public partial class NearbyrestaurantsView : ObservableObject
    {
        private readonly IMap map;
        private readonly IGeolocation geolocation;
        private readonly IConnectivity connectivity;

        public NearbyrestaurantsView(IMap map, IGeolocation geolocation,IConnectivity connectivity)
        {
            this.map = map;
            this.geolocation = geolocation;
            this.connectivity = connectivity;
        }


        [RelayCommand]

        public async Task CheckLocation()
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("OPS", "You need Internet Connection for this", "Ok");
                return;
            }
            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("OPS", "You need Internet Connection for this", "Ok");
                return;
            }

            var location = await geolocation.GetLastKnownLocationAsync();
            if(location ==null)
            {
                location = await geolocation.GetLocationAsync(
                   new GeolocationRequest
                   {
                       DesiredAccuracy=GeolocationAccuracy.Best,
                       Timeout = TimeSpan.FromSeconds(40),
                       RequestFullAccuracy = true

                   });;
            }

            if(location == null)
            {
                await Shell.Current.DisplayAlert("OPS", "Sorry you couldnt get your location", "Ok");
                return;
            }


            await map.OpenAsync(location.Latitude, location.Longitude, new MapLaunchOptions
            {
                Name = "My Current Location ",
                NavigationMode = NavigationMode.None
            });
        }
    }
}

