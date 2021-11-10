using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class HospitalizasyonBedValidator : AbstractValidator<HospitalizasyonBed>
    {
        public HospitalizasyonBedValidator()
        {
            RuleFor(h => h.Name).NotEmpty();
            RuleFor(h => h.Name).MinimumLength(3);
        }
    }
}
