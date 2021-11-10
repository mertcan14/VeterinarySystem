using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DistrictValidator : AbstractValidator<District>
    {
        public DistrictValidator()
        {
            RuleFor(d => d.Name).NotEmpty();
            RuleFor(d => d.Name).MinimumLength(3);
            RuleFor(d => d.Name).MaximumLength(20);
        }
    }
}
