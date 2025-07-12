using Ecommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoService _productoService;
        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }
        public async Task<IActionResult> Index()
        {
            var productos = await _productoService.ObtenerCatalogoAsync();
            return View(productos);
        }
        public IActionResult Crear()
        {
            return View();
        }
    }
}
