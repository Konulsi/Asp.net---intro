using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
