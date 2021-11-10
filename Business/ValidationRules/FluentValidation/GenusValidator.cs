using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class GenusValidator : AbstractValidator<Genus>
    {
        public GenusValidator()
        {
            RuleFor(g => g.Name).NotEmpty();
            RuleFor(g => g.Name).MinimumLength(2);
        }
    }
}
