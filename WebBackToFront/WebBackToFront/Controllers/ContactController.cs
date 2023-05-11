using Microsoft.AspNetCore.Mvc;

namespace WebBackToFront.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
