using Restaurant.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Cliente:EntityBase
    {
        public string Nombres { get; set; } = default!;
        public string Apellidos { get; set; } = default!;
        public DateTime? FechaNacimiento { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = default!;
        public string NumeroDocumento { get; set; } = default!;
        public string? NumeroTelefonoMovil { get; set; }
        public string? CorreoElectronico { get; set; }
    }
}
