using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class DetallePedido:EntityBase
    {
        public int Secuencia { get; set; } = default!;
        public int Cantidad { get; set; } = default!;
        public decimal Precio { get; set; } = default!;
        public decimal? Descuento { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; } = default!;
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }

    }
}
