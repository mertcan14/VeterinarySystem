using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class InComeValidator : AbstractValidator<InCome>
    {
        public InComeValidator()
        {
            RuleFor(i => i.Price).NotEmpty();
            RuleFor(i => i.Price).GreaterThan(0);

            RuleFor(i => i.Date).Must(DateValid).WithMessage("Tarih ileri zamanlı olamaz");
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
