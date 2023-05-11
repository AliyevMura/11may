using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebBackToFront.DAL;

namespace WebBackToFront
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));


            });
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            //app.MapGet("/", () => "Hello World!");
            
            app.Run();
        }
    }
}