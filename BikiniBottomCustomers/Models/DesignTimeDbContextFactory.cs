using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BikiniBottomCustomers.Models
{
  public class BikiniBottomCustomersContextFactory : IDesignTimeDbContextFactory<BikiniBottomCustomersContext>
  {

    BikiniBottomCustomersContext IDesignTimeDbContextFactory<BikiniBottomCustomersContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BikiniBottomCustomersContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new BikiniBottomCustomersContext(builder.Options);
    }
  }
}