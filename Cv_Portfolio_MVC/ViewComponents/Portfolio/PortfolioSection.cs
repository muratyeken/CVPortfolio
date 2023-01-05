using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Portfolio
{
    public class PortfolioSection:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolio());
        public IViewComponentResult Invoke()
        {
            
            var values = portfolioManager.GetListT();
            return View(values);
            
        }
    }
}
