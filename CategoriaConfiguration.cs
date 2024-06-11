using System;
using System.Collections.Generic;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        //data seeding; creamos registros para que EF los inserte al migrar.
        var categorias = new List<Categoria>
        {
            new() {Id=1, Nombre="Celulares" },
            new() {Id=2, Nombre="Televisores" },
            new() {Id=3, Nombre="Computadores" },
        };

        builder.HasData(categorias);
    }
}
