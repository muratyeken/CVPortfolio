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
    public class SkillManager : ISkillService
    {
        ISkill _skill;

        public SkillManager(ISkill skill)
        {
            _skill = skill;
        }

        public void AddT(Skill t)
        {
            _skill.Insert(t);
        }

        public void DeleteT(Skill t)
        {
            _skill.Delete(t);
        }

        public Skill GetByIDT(int id)
        {
            return _skill.GetByID(id);
        }

        public List<Skill> GetListT()
        {
            return _skill.GetList();
        }

        public void UpdateT(Skill t)
        {
            _skill.Update(t);
        }
    }
}
