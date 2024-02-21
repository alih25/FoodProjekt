
using FoodProjekt.api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodProjekt.api.Data
{
    public partial class DataContext
    {
       
        public void ServiceData(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Category>()
				.HasData(

				 new Category(1, "Burgers", "burgers.png"),
			   new Category(2, "Desserts", "dessert.png"),
			   new Category(3, "Drinks", "drinks.png"),
			   new Category(4, "Pizza", "pizza.png"),
			   new Category(5, "Seafood", "seafood.png"),
			   new Category(6, "Soups", "soup.png"),
			   new Category(7, "Vegetarian", "veg.png")

				);

			modelBuilder.Entity<Offer>()
				.HasData(

				 new Offer(1, "50 Percent Off", "femtio.png", "50 Percent on all food types", "OFF-50", OfferType.Percentage, 50, null, DateTime.Now.AddDays(7)),
				new Offer(2, "Special Offer", "special.png", "Special offer on all food types", "SPEC-150", OfferType.Flat, 150, null, DateTime.Today),
				new Offer(3, "Upto 50% OFF", "upto50.png", "Upto 50% OFF", "UPTO-50", OfferType.Percentage, 50, 500, null),
				new Offer(4, "70 Percent Off", "sjuttio.png", "70 Percent on all food types", "OFF-70", OfferType.Percentage, 70, null, DateTime.Now.AddDays(2)),
				new Offer(5, "40% SALE OFF", "fyrtio.png", "40 Percent on all food types", "OFF-40", OfferType.Percentage, 40, null, DateTime.Now.AddDays(4)),
				new Offer(6, "SALE 30% OFF", "trettio.png", "30 Percent on all food types", "OFF-30", OfferType.Percentage, 30, 300, DateTime.Now.AddMonths(1))

				);
        }

	}
}
