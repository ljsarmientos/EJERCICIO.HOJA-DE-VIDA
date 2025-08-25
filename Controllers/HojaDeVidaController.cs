using Microsoft.AspNetCore.Mvc;

namespace HojaDeVidaMVC.Controllers
{
    public class HojaDeVidaController : Controller
    {
        public IActionResult Index()
        {
            return View(); // va a buscar Views/HojaDeVida/Index.cshtml
        }
    }
}
