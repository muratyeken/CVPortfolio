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
            throw new NotImplementedException();
        }

        public void DeleteT(Experience t)
        {
            throw new NotImplementedException();
        }

        public Experience GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> GetListT()
        {
            return _experience.GetList();
        }

        public void UpdateT(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
