using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AddressValidator: AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.FirstName).NotEmpty();
            RuleFor(a => a.FirstName).MinimumLength(2);

            RuleFor(a => a.LastName).NotEmpty();
            RuleFor(a => a.LastName).MinimumLength(2);

            RuleFor(a => a.AddressTitle).NotEmpty();
            RuleFor(a => a.AddressTitle).MinimumLength(3);
            RuleFor(a => a.AddressTitle).MaximumLength(14);

            RuleFor(a => a.Definition).NotEmpty();
        }
    }
}
