namespace Ecommerce.Models
{
    public class CarritoItem : EntityBase
    {
        public int UsuarioId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
