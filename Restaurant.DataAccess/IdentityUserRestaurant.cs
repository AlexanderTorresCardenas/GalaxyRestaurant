using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.DataAccess;

public class IdentityUserRestaurant : IdentityUser
{
    [StringLength(200)]
    public string NombreCompleto { get; set; } = default!;

    public DateTime FechaNacimiento { get; set; }

    [StringLength(250)]
    public string? Direccion { get; set; }
}
