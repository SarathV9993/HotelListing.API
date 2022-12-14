using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext hotelListingDbContext;

        public CountriesRepository(HotelListingDbContext hotelListingDbContext) : base(hotelListingDbContext)
        {
            this.hotelListingDbContext = hotelListingDbContext;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await hotelListingDbContext.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
