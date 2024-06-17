using Restaurant.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Shared;

public class ClienteDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = Constantes.CampoRequerido)]
    [Display(Name = "Nombres")]
    public string Nombres { get; set; } = default!;

    [Required(ErrorMessage = Constantes.CampoRequerido)]
    [Display(Name = "Apellidos")]
    public string Apellidos { get; set; } = default!;
    public DateTime? FechaNacimiento { get; set; }
    public TipoDocumento TipoDocumento { get; set; } = default!;

    [Required(ErrorMessage = Constantes.CampoRequerido)]
    [Display(Name = "Numero de documento")]
    public string NumeroDocumento { get; set; } = default!;
    public string? NumeroTelefonoMovil { get; set; }

    [EmailAddress]
    public string? CorreoElectronico { get; set; }
}
