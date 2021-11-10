using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AnimalValidator: AbstractValidator<Animal>
    {
        public AnimalValidator()
        {
            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Name).MinimumLength(3);
            RuleFor(a => a.Name).MaximumLength(30);
        }
    }
}
