using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Resume
{
    public class ResumeSection:ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperience());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.GetListT();
            return View(values);
        }
    }
}
