using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Categoria : EntityBase
    {
        public string Descripcion { get; set; } = default!;
    }
}
