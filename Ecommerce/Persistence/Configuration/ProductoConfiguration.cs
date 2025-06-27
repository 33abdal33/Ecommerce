using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Persistence.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos");

            builder.Property(p => p.Nombre)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(p => p.Descripcion)
                   .HasMaxLength(500);

            builder.Property(p => p.Precio)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(p => p.Stock)
                   .IsRequired();

            builder.Property(p => p.ImagenUrl)
                   .HasMaxLength(300);

            builder.HasOne(p => p.Categoria)
                   .WithMany(c => c.Productos)
                   .HasForeignKey(p => p.CategoriaId);
        }
    }
}
