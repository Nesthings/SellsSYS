using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicaciónWeb.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
