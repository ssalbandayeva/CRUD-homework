using Microsoft.AspNetCore.Mvc;
using Pronia.Contexts;
using Pronia.Models;
using Pronia.ViewModels;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;


        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Service> services = _context.Services.ToList();


            HomeViewModel homeViewModel = new()
            {
                Sliders = sliders,
                Services = services
            };

            return View(homeViewModel);
        }
    }
}
