using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        public AppointmentValidator()
        {
            RuleFor(a => a.Definition).NotEmpty();
            RuleFor(a => a.AppointmentDate).NotEmpty();
        }
    }
}
