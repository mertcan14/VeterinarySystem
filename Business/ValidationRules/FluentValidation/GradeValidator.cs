using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class GradeValidator : AbstractValidator<Grade>
    {
        public GradeValidator()
        {
            RuleFor(g => g.Name).NotEmpty();
            RuleFor(g => g.Name).MinimumLength(2);
        }
    }
}
