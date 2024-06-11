using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.Configurations
{
    public class DetalleComandaConfiguration : IEntityTypeConfiguration<DetalleComanda>
    {
        public void Configure(EntityTypeBuilder<DetalleComanda> builder)
        {
            builder.Property(p => p.Precio)
            .IsRequired();

            builder.Property(p => p.Cantidad)
           .IsRequired();
        }
    }
}
