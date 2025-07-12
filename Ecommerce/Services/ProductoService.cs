using Ecommerce.Models;
using Ecommerce.Persistence;
using Ecommerce.Repository;

namespace Ecommerce.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repo;

        public ProductoService(IProductoRepository repo)
        {
            _repo = repo;
        }
        public Task<List<Producto>> ObtenerCatalogoAsync()
        {
            return _repo.ObtenerTodosAsync();
        }
        public Task<Producto?> ObtenerPorIdAsync(int id)
        {
            return _repo.ObtenerPorIdAsync(id);
        }
        public async Task CrearProductoAsync(Producto producto)
        {
            await _repo.CrearAsync(producto);
            await _repo.GuardarCambiosAsync();
        }
        public async Task ActualizarProductoAsync(Producto producto)
        {
            await _repo.ActualizarAsync(producto);
            await _repo.GuardarCambiosAsync();
        }
        public async Task EliminarProductoAsync(int id)
        {
            var producto = await _repo.ObtenerPorIdAsync(id);
            if(producto is not null)
            {
                await _repo.EliminarAsync(producto);
                await _repo.GuardarCambiosAsync();
            }
        }
    }
}
