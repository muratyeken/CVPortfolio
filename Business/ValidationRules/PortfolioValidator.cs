using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
           RuleFor(x => x.Name).NotEmpty().WithMessage("You must enter a project name."); 
           RuleFor(x => x.Name).MinimumLength(5).WithMessage("a minimum of 5 characters must be entered "); 
           RuleFor(x => x.Name).MaximumLength(100).WithMessage("a maximum of 25 characters must be entered "); 

           RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("You must enter an image url."); 
        }
    }
}
