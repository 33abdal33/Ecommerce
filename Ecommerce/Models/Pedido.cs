namespace Ecommerce.Models
{
    public class Pedido : EntityBase
    {
        public DateTime FechaPedido { get; set; } = DateTime.UtcNow;
        public int UsuarioId { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } = "Pendiente";

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<DetallePedido> Detalles { get; set; }
    }
}
