using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAbout());

        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutManager.GetByIDT(1);
            return View(values);
        }
        public IActionResult Index(About about)
        {
            aboutManager.UpdateT(about);
            return RedirectToAction("Index","Default");
        }
    }
}
