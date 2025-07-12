using Ecommerce.Models;
using Ecommerce.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producto>> ObtenerTodosAsync() =>
             await _context.Productos.Include(p => p.Categoria).ToListAsync();

        public async Task<Producto?> ObtenerPorIdAsync(int id) =>
             await _context.Productos.Include(p => p.Categoria).FirstOrDefaultAsync(p => p.Id == id);

        public async Task CrearAsync(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
        }

        public Task ActualizarAsync(Producto producto)
        {
            _context.Productos.Update(producto);
            return Task.CompletedTask;
        }

        public Task EliminarAsync(Producto producto)
        {
            _context.Productos.Remove(producto);
            return Task.CompletedTask;
        }

        public async Task GuardarCambiosAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
