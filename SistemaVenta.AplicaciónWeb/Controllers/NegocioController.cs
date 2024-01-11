using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicaciónWeb.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
