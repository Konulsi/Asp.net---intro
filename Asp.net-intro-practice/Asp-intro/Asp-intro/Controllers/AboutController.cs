using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
