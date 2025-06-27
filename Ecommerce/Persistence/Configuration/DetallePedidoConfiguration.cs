using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Persistence.Configuration
{
    public class DetallePedidoConfiguration : IEntityTypeConfiguration<DetallePedido>
    {
        public void Configure(EntityTypeBuilder<DetallePedido> builder)
        {
            builder.ToTable("DetallesPedido");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Cantidad)
                   .IsRequired();

            builder.Property(d => d.PrecioUnitario)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.HasOne(d => d.Pedido)
                   .WithMany(p => p.Detalles)
                   .HasForeignKey(d => d.PedidoId);

            builder.HasOne(d => d.Producto)
                   .WithMany(p => p.DetallesPedidos)
                   .HasForeignKey(d => d.ProductoId);
        }
    }
}
