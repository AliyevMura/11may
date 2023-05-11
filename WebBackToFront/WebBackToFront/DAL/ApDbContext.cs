using Microsoft.EntityFrameworkCore;
using WebBackToFront.Models;

namespace WebBackToFront.DAL
{
    public class ApDbContext:DbContext
    {


        public ApDbContext(DbContextOptions<ApDbContext> options):base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ServiceImage> ServiceImages { get; set; }
    }
}
