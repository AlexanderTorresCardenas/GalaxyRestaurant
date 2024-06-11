using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Entities.Enums;

namespace Restaurant.Entities
{
    public class Mesero: EntityBase
    {
        public string Nombres { get; set; } = default!;
        public string Apellidos { get; set; } = default!;
        public TipoDocumento TipoDocumento { get; set; } = default!;
        public string NumeroDocumento { get; set; } = default!;
        public string? NumeroTelefono { get; set; }
        public string? CorreoElectronico { get; set; }


    }
}
