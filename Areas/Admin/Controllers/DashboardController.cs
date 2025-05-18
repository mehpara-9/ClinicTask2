using Clinictask.Contexts;
using Clinictask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinictask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public DashboardController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            List<Category> categories = _appDbContext.Category.Include(d => d.Healthcareolutions).ToList();
            return View(categories);
        }
     
    }
}
