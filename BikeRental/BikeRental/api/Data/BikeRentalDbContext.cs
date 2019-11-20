using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class BikeRentalDbContext : DbContext
    {
        public BikeRentalDbContext(DbContextOptions<BikeRentalDbContext> options)
        : base(options)
        { }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Rental>  Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
