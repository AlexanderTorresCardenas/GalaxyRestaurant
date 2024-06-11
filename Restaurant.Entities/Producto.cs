using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Producto: EntityBase
    {
        public string Nombre { get; set; } = default!;
        public string Descripcion { get; set; } = default!;
        public decimal Precio { get; set; } = default!;
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; } = default!;

    }
}
