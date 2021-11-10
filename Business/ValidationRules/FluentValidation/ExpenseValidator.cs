using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ExpenseValidator : AbstractValidator<Expense>
    {
        public ExpenseValidator()
        {
            RuleFor(e => e.Price).NotEmpty();
            RuleFor(e => e.Price).GreaterThan(0);

            RuleFor(e => e.Date).NotEmpty();
            RuleFor(e => e.Date).Must(DateValid).WithMessage("Tarih girislerini gelecekten yapamazsınız");
        }

        private bool DateValid(DateTime dateTime)
        {
            DateTime timeNow = DateTime.Now;
            if (dateTime > timeNow)
            {
                return false;
            }
            return true;
        }
    }
}
