using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Comanda : EntityBase
    {
        public DateTime FechaComanda { get; set; } = default!;
        public decimal SubTotal { get; set; } = default!;
        public decimal Igv { get; set; } = default!;
        public decimal Total { get; set; } = default!;
        public Mesero Mesero { get; set; } = default!;
        public int MeseroId { get; set; }
        public Cliente Cliente { get; set; } = default!;
        public int ClienteId { get; set; }
        public Sucursal Sucursal { get; set; } = default!;
        public int SucrursalId { get; set; }
        public ICollection<DetalleComanda> DetalleComandas { get; set; } = new List<DetalleComanda>();

        public Comanda()
        {
            FechaComanda  = DateTime.Now;
        }
    }
}
