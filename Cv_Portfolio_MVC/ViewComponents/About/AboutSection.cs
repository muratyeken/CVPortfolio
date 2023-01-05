using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.About
{
    public class AboutSection:ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAbout());

        public IViewComponentResult Invoke()
        {
            var values = aboutManager.GetListT();
            return View(values);
        }
        
    }
}
