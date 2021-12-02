using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=> c.FirstName).NotEmpty();
            RuleFor(c => c.FirstName).MinimumLength(2);

            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.LastName).MinimumLength(2);

            RuleFor(c => c.PhoneNumber).NotEmpty();
            RuleFor(c => c.PhoneNumber).Length(10,10);
        }
    }
}
