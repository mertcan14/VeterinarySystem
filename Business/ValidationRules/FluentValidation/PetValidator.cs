using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PetValidator : AbstractValidator<Pet>
    {
        public PetValidator()
        {
            RuleFor(p => p.MicrochipNumber).Length(15,15);

            RuleFor(p => p.Name).Length(2,20);
            RuleFor(p => p.Name).NotEmpty();

            RuleFor(p => p.BirthYear).Must(BirthValidator).WithMessage("İleri tarihli giriş yaptınız.");
            RuleFor(p => p.BirthYear).NotEmpty();

            RuleFor(p => p.Color).NotEmpty();
        }

        private bool BirthValidator(int birthYear)
        {
            DateTime time = DateTime.Now;
            if (time.Year >= birthYear)
            {
                return true;
            }
            return false;
        }
    }
}
