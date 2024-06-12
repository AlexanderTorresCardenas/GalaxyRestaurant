using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Shared;

namespace Restaurant.DataAccess;

public static class UserDataSeeder
{
    public static async Task Seed(IServiceProvider service)
    {
        // UserManager (Repositorio de Usuarios)
        var userManager = service.GetRequiredService<UserManager<IdentityUserRestaurant>>();
        // RoleManager (Repositorio de Roles)
        var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

        // Crear los roles
        var adminRole = new IdentityRole(Constantes.RolAdministrador);
        var clienteRole = new IdentityRole(Constantes.RolCliente);
        var meseroRole = new IdentityRole(Constantes.RolMesero);

        if (!await roleManager.RoleExistsAsync(Constantes.RolAdministrador))
        {
            await roleManager.CreateAsync(adminRole);
        }

        if (!await roleManager.RoleExistsAsync(Constantes.RolCliente))
        {
            await roleManager.CreateAsync(clienteRole);
        }

        if (!await roleManager.RoleExistsAsync(Constantes.RolMesero))
        {
            await roleManager.CreateAsync(meseroRole);
        }

        // Creamos el usuario Administrador
        var adminUser = new IdentityUserRestaurant
        {
            NombreCompleto = "Administrador del Restaurant",
            FechaNacimiento = DateTime.Parse("1990-01-01"),
            Direccion = "Av. Las delicias 123",
            UserName = "admin",
            Email = "admin@gmail.com",
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(adminUser, "pa$$W0rD@123");
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(adminUser, Constantes.RolAdministrador);
        }
    }
}
