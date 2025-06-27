using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Persistence.Configuration
{
    public class CarritoItemConfiguration : IEntityTypeConfiguration<CarritoItem>
    {
        public void Configure(EntityTypeBuilder<CarritoItem> builder)
        {
            builder.ToTable("CarritoItems");

            builder.Property(c => c.Cantidad)
                   .IsRequired();

            builder.HasOne(c => c.Usuario)
                   .WithMany(u => u.Carrito)
                   .HasForeignKey(c => c.UsuarioId);

            builder.HasOne(c => c.Producto)
                   .WithMany(p => p.CarritoItems)
                   .HasForeignKey(c => c.ProductoId);
        }
    }
}
