using Microsoft.AspNetCore.Mvc;

namespace WebBackToFront.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
