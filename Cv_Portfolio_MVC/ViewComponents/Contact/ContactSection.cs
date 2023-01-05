using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Contact
{
    public class ContactSection:ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContact());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.GetListT();
            return View(values);
        }
    }
}
