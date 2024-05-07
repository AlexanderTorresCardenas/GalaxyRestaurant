using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Pedido : EntityBase
    {
        public DateTime FechaPedido { get; set; } = default!;
        public decimal SubTotal { get; set; } = default!;
        public decimal Igv { get; set; } = default!;
        public decimal Total { get; set; } = default!;
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; } = default!;
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; } = default!;
        public Sucursal Sucursal { get; set; }
        public int SucrursalId { get; set; } = default!;
    }
}
