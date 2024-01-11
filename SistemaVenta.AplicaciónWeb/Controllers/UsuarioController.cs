using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicaciónWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
