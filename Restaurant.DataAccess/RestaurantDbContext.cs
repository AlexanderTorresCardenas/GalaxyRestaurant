using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Restaurant.DataAccess;

public class RestaurantDbContext : IdentityDbContext<IdentityUserRestaurant>//DbContext para las tablas del sistema
{
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
    {
           
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);

        configurationBuilder.Properties<string>()
            .HaveMaxLength(100);

        configurationBuilder.Properties<DateTime>()
            .HaveColumnType("DATE");
    }
}
