using Microsoft.AspNetCore.Mvc;

namespace GrassyWomen.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
