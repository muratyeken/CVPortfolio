using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Contact
{
    public class SendMessage : ViewComponent

    {
        MessageManager messageManager = new MessageManager(new EfMessage());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message m)
        //{
        //    m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    m.Status = true;
        //    messageManager.AddT(m);
        //    return View();
        //}
    }

}
