using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Persistence.Configuration
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");

            builder.Property(p => p.FechaPedido)
                   .IsRequired();

            builder.Property(p => p.Total)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(p => p.Estado)
                   .HasMaxLength(50);

            builder.HasOne(p => p.Usuario)
                   .WithMany(u => u.Pedidos)
                   .HasForeignKey(p => p.UsuarioId);
        }
    }
}
