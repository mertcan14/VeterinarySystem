using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Company).NotEmpty();
            RuleFor(p => p.Company).MaximumLength(50);

            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);

            RuleFor(p => p.StockQuantity).NotEmpty();
            RuleFor(p => p.StockQuantity).GreaterThanOrEqualTo(0);
        }
    }
}
