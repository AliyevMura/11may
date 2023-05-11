using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBackToFront.DAL;
using WebBackToFront.Models;

namespace WebBackToFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApDbContext _apDbContext;
        public HomeController(ApDbContext apDbContext)
        {
          _apDbContext = apDbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders =await _apDbContext.Sliders.ToListAsync();
            return View(sliders);
        }
    }
}
