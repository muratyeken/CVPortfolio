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
    public class ExperienceManager : IExperienceService
    {
        IExperience _experience;

        public ExperienceManager(IExperience experience)
        {
            _experience = experience;
        }

        public void AddT(Experience t)
        {
            _experience.Insert(t);
        }

        public void DeleteT(Experience t)
        {
            _experience.Delete(t);

        }

        public Experience GetByIDT(int id)
        {
            return _experience.GetByID(id);
        }

        public List<Experience> GetListT()
        {
            return _experience.GetList();
        }

        public void UpdateT(Experience t)
        {
            _experience.Update(t);
        }
    }
}
