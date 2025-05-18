using Clinictask.Contexts;
using Clinictask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Clinictask.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ServiceController(AppDbContext appDbContext)
        {
          
       
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            List<Service> services = _appDbContext.Service.Include(d => d.Healthcareolutions).ToList();
            return View(services);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
       
        public IActionResult Create(Service service)
        {
            if (!ModelState.IsValid) { return View(); }
            if (service.ImageUpload == null || !service.ImageUpload.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageUpload", "File must be image format");
                return View(service);
            }
            string filename = service.ImageUpload.FileName;
            string path = "C:\\Users\\Admin\\Desktop\\c#\\New folder\\Clinictask\\wwwroot\\UploadImages\\Services\\";
            using (FileStream filestream=new FileStream(path+filename, FileMode.Create))
            {
                service.ImageUpload.CopyTo(filestream);
            }
            service.ImgUrl = filename;
            _appDbContext.Add(service);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
      



    

}
}
