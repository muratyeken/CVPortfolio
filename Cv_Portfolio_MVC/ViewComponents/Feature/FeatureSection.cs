using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Feature
{
    public class FeatureSection: ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
