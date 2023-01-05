using Business.Concrete; 
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.SocialMedia
{
    public class SocialMediaSection:ViewComponent        
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMedia());
        public IViewComponentResult Invoke()
        {
            var values = socialMediaManager.GetListT();
            return View(values);
        }

    }
}
