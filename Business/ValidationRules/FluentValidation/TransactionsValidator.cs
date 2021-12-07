using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class TransactionsValidator : AbstractValidator<Transactions>
    {
        public TransactionsValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Name).MinimumLength(2);

            RuleFor(t => t.Price).GreaterThan(0);
            RuleFor(t => t.Price).NotEmpty();

            RuleFor(t => t.Pet).NotEmpty();
        }
    }
}
