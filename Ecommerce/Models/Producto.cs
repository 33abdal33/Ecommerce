namespace Ecommerce.Models
{
    public class Producto : EntityBase
    {
        public string Nombre { get; set; } = default!;
        public string Descripcion { get; set; } = default!;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string ImagenUrl { get; set; } = default!;
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<DetallePedido> DetallesPedidos { get; set; }
        public virtual ICollection<CarritoItem> CarritoItems { get; set; }
    }
}
