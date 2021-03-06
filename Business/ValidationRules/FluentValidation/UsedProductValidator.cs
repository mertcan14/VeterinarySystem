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
            RuleFor(u => u.ProductId).NotEmpty();
            RuleFor(u => u.TransactionsId).NotEmpty();
        }
    }
}
