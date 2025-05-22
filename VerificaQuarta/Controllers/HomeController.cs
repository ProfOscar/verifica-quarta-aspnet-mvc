using Microsoft.AspNetCore.Mvc;

namespace VerificaQuarta.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
