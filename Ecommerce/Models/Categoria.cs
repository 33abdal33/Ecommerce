namespace Ecommerce.Models
{
    public class Categoria : EntityBase
    {
        public string Nombre { get; set; } = default!;
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
