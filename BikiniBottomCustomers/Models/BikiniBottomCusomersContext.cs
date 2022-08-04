using Microsoft.EntityFrameworkCore;

namespace BikiniBottomCustomers.Models
{
  public class BikiniBottomCustomersContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<CustomerRestaurant> CustomerRestaurant { get; set; }

    public BikiniBottomCustomersContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}