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
    public class AboutManager : IAboutService

    {
        IAbout _About;

        public AboutManager(IAbout about)
        {
            _About = about;
        }

        public void AddT(About t)
        {
            _About.Insert(t);
        }

        public void DeleteT(About t)
        {
            _About.Delete(t);
        }

        public About GetByIDT(int id)
        {
            return _About.GetByID(id);
        }

        public List<About> GetListT()
        {
            return _About.GetList();
        }

        public void UpdateT(About t)
        {
            _About.Update(t);
        }
    }
}
