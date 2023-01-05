using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.ViewComponents.Skill
{
    public class SkillSection:ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkill());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.GetListT();
            return View(values);
        }
    }
}
