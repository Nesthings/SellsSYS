using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicaciónWeb.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
