using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Entities;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.Property(p => p.Nombres)
           .HasMaxLength(100);

        builder.Property(p => p.Apellidos)
           .HasMaxLength(200);

        builder.Property(p => p.CorreoElectronico)
            .IsUnicode(false)
            .HasMaxLength(100);

        builder.Property(p => p.NumeroTelefonoMovil)
         .HasMaxLength(9);
    }
}
