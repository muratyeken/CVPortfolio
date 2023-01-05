using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
