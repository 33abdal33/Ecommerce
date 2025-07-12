using Ecommerce.Models;

namespace Ecommerce.Services
{
    public interface IProductoService
    {
        Task<List<Producto>> ObtenerCatalogoAsync();
        Task<Producto?> ObtenerPorIdAsync(int id);
        Task CrearProductoAsync(Producto producto);
        Task ActualizarProductoAsync(Producto producto);
        Task EliminarProductoAsync(int id);
    }
}
