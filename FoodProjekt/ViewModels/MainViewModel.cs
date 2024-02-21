
//using AVFoundation;
using CommunityToolkit.Mvvm.Input;
using System.Net.Http.Json;

namespace FoodProjekt.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private IEnumerable<Category> _categories;
        [ObservableProperty]
        private IEnumerable<Offer> _offers;
        private readonly HttpClient _httpClient;

        public MainViewModel(IHttpClientFactory httpClientFactory)
        {
            //Categories = LoadCategories();
            Offers = LoadOffers();
            _httpClient = httpClientFactory.CreateClient(AppConstants.ApiHttpClientName);
        }


        public async Task InitializeAsync()
        {
            Categories = await LoadCategoriesAsync();
        }

        [RelayCommand]
        private async Task SelectOfferAsync(Offer offer) 
        {

            await Shell.Current.DisplayAlert("Offer Tapped", $"Offer {offer} is selected. We will move to a new page for offer details","Ok");
        
        }
        //private async Task<IEnumerable<Category>> LoadCategoriesAsync()
        //{
        //    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>("https://localhost:7075/api/Categories");
        //    return categories;
        //}

        private async Task<IEnumerable<Category>> LoadCategoriesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7075/api/categories");

                if (response.IsSuccessStatusCode)
                {
                    var categories = await response.Content.ReadFromJsonAsync<IEnumerable<Category>>();
                    return categories;
                }
                else
                {
                    // Handle the error or return an empty list if the request fails.
                    return new List<Category>();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Category>();
            }
        }

        //private static IEnumerable<Category> LoadCategories()
        //{
        //    return new List<Category>()
        //    {
        //       new Category (1,"Burgers","burgers.png"),
        //       new Category (2,"Desserts","dessert.png"),
        //       new Category (3,"Drinks","drinks.png"),
        //       new Category (4,"Pizza","pizza.png"),
        //       new Category (5,"Seafood","seafood.png"),
        //       new Category (6,"Soups","soup.png"),
        //       new Category (7,"Vegetarian","veg.png"),

        //    };
        //}
        private static IEnumerable<Offer> LoadOffers()
        {
            return new List<Offer>
            {
                new Offer(1,"50 Percent Off","femtio.png","50 Percent on all food types","OFF-50",OfferType.Percentage,50,null,DateTime.Now.AddDays(7)),
                new Offer(2,"Special Offer","special.png","Special offer on all food types","SPEC-150",OfferType.Flat,150,null,DateTime.Today),
                new Offer(3,"Upto 50% OFF","upto50.png","Upto 50% OFF","UPTO-50",OfferType.Percentage,50,500,null),
                new Offer(4,"70 Percent Off","sjuttio.png","70 Percent on all food types","OFF-70",OfferType.Percentage,70,null,DateTime.Now.AddDays(2)),
                new Offer(5,"40% SALE OFF","fyrtio.png","40 Percent on all food types","OFF-40",OfferType.Percentage,40,null,DateTime.Now.AddDays(4)),
                new Offer(6,"SALE 30% OFF","trettio.png","30 Percent on all food types","OFF-30",OfferType.Percentage,30,300,DateTime.Now.AddMonths(1))
            };

        }
    }
}
