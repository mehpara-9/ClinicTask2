using Clinictask.Contexts;
using Clinictask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinictask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            List<Category> categories = _appDbContext.Category.Include(d => d.Healthcareolutions).ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid == null) { return BadRequest("Something went wrong"); }
            _appDbContext.Add(category);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Category? category = _appDbContext.Category.Find(id);
            if (category == null) { return NotFound("tapilmadi"); }
            _appDbContext.Remove(category);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            Category? existingcategory = _appDbContext.Category.Find(id);
            if (existingcategory == null) { return NotFound("Couldn't be found"); }
            return View(nameof(Create), existingcategory);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Title", "Title mecbur yazilmalidir");
                return View(nameof(Create), category);
            }
            Category? existingcategory = _appDbContext.Category.AsNoTracking().FirstOrDefault(c => c.Id == category.Id);
            if (existingcategory == null) { return NotFound("Couldn't be found"); }
            _appDbContext.Category.Update(category);
            _appDbContext.SaveChanges();
            return View(nameof(Index));
        }
    }
}
