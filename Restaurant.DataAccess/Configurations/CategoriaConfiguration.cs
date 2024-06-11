using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Entities;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.Property(p => p.Descripcion)
          .HasMaxLength(50);

        var categorias = new List<Categoria>
        {
            new() {Id=1, Descripcion="Entradas" },
            new() {Id=2, Descripcion="Sopas" },
            new() {Id=3, Descripcion="Fondos" },
            new() {Id=4, Descripcion="Gaseosas" },
            new() {Id=5, Descripcion="Cevezas" },
            new() {Id=6, Descripcion="Vinos" },
            new() {Id=7, Descripcion="Agua" },
        };

        builder.HasData(categorias);
    }
}
