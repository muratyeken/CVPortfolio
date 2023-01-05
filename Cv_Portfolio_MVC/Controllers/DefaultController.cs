using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavBarPartial() 
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message m)
        {
            MessageManager messageManager = new MessageManager(new EfMessage());
            m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m.Status = true;
            messageManager.AddT(m);
            
            return PartialView();
        }
    }
}
