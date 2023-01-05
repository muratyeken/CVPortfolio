using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Testimonial
{
    public class TestimonialSection:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonial());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.GetListT();
            return View(values);
        }
    }
}
