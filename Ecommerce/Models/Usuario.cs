namespace Ecommerce.Models
{
    public class Usuario : EntityBase
    {
        public string Nombre { get; set; } = default!;
        public string Correo { get; set; } = default!;
        public string ContrasenaHash { get; set; } = default!;
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<CarritoItem> Carrito { get; set; }
    }
}
