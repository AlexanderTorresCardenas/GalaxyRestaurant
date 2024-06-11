using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class DetalleComanda:EntityBase
    {
        public int Secuencia { get; set; } = default!;
        public int Cantidad { get; set; } = default!;
        public decimal Precio { get; set; } = default!;
        public decimal? Descuento { get; set; }
        public Comanda Comanda { get; set; } = default!;
        public int ComandaId { get; set; } 
        public Producto Producto { get; set; } = default!;
        public int ProductoId { get; set; }

    }
}
