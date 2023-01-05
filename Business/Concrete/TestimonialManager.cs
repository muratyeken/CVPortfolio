using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonial _testimonial;

        public TestimonialManager(ITestimonial testimonial)
        {
            _testimonial = testimonial;
        }

        public void AddT(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetListT()
        {
            return _testimonial.GetList();
        }

        public void UpdateT(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
