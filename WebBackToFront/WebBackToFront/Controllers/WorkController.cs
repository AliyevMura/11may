using Microsoft.AspNetCore.Mvc;

namespace WebBackToFront.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
