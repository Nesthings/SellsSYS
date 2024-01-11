using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicaciónWeb.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
