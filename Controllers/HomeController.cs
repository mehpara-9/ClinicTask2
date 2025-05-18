using Clinictask.Contexts;
using Clinictask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinictask.Controllers
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
            List<Healthcareolution> healthcaresolutions = _context.HealthCareSolutions.Include(hC => hC.Category).ToList();
            return View(healthcaresolutions);
        }
    }
}
