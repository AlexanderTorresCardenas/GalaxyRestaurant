using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Sucursal:EntityBase
    {
        public string Nombre { get; set; } = default!;
        public string? Direccion { get; set;}
        public string Telefono { get; set; } = default!;
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }

        public Restaurant Restaurant { get; set; } = default!;
        public int RestorantId { get; set; }= default!;
    }
}
