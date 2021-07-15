using Microsoft.AspNetCore.Mvc;

namespace DEVIO.PrimeiroProjeto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}