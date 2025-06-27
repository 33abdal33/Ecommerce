using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Persistence.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.Property(u => u.Nombre)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.Correo)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(u => u.ContrasenaHash)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.FechaRegistro)
                   .IsRequired();
        }
    }
}
