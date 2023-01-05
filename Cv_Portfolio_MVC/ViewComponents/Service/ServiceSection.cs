using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Service
{
    public class ServiceSection:ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfService());

        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetListT();
            return View(values);
        }
    }
}
