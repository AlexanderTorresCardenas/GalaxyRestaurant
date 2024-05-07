using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Restaurant: EntityBase
    {
        public string RazonSocial { get; set; } = default!;
        public string Ruc { get; set; } = default!;
        public string Direccion { get; set; } = default!;
        public string? Telefono { get; set; }
    }
}
