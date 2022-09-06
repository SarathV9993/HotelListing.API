using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData
                (
                    new Country
                    {
                        Id = 1,
                        Name = "India",
                        ShortName = "IN"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Maldives",
                        ShortName = "ML"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Mauritius",
                        ShortName = "MR"
                    }
                );
            modelBuilder.Entity<Hotel>().HasData
                (
                    new Hotel
                    {
                        Id = 1,
                        Name = "Taj Deccan",
                        Address = "Hyderabad",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Ritz Carlton",
                        Address = "Panama Island",
                        CountryId = 2,
                        Rating = 4.7
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Mariott",
                        Address = "Sentinel Island",
                        CountryId = 3,
                        Rating = 4.8
                    }
                );

        }
    }
}
