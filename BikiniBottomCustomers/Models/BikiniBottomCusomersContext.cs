using Microsoft.EntityFrameworkCore;

namespace BikiniBottomCustomers.Models
{
  public class BikiniBottomCustomersContext : DbContext
  {
    public DbSet<CLassOne> ClassOne { get; set; }
    public DbSet<ClassTwo> ClassTwo { get; set; }

    public BikiniBottomCustomersContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}