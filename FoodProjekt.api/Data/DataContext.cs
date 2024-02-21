using FoodProjekt.api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodProjekt.api.Data
{
    public partial class DataContext : DbContext
    {
        public const string ConnectionStringName = "FoodProjekt";
        public DataContext():base()
        {
            
        }

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

   
            ServiceData(modelBuilder);
        }

        
    }
}
