using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;

namespace Cv_Portfolio_MVC.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolio());
        public IActionResult Index()
        {
            var values = portfolioManager.GetListT();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidator validations= new PortfolioValidator();   
            ValidationResult results= validations.Validate(p);
            if (results.IsValid)
            {
                portfolioManager.AddT(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values=portfolioManager.GetByIDT(id);
            portfolioManager.DeleteT(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = portfolioManager.GetByIDT(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator(); 
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                portfolioManager.UpdateT(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
            
        }
       
    }
}
