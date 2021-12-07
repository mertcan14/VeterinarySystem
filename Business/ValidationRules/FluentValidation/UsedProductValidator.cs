using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UsedProductValidator : AbstractValidator<UsedProduct>
    {
        public UsedProductValidator()
        {
            RuleFor(u => u.Product).NotEmpty();
            RuleFor(u => u.Transactions).NotEmpty();
        }
    }
}
