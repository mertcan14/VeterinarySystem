using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class HospitalizasyonValidator : AbstractValidator<Hospitalizasyon>
    {
        public HospitalizasyonValidator()
        {
            RuleFor(h => h.EntryDate).NotEmpty();
            RuleFor(h => h).Must(DateValid).When(h=>h.ReleaseDate!=null).WithMessage("Giriş tarihi çıkış tarihinden ileri olamaz");

        }

        private bool DateValid(Hospitalizasyon hospitalizasyon)
        {
            if (hospitalizasyon.EntryDate > hospitalizasyon.ReleaseDate)
            {
                return false;
            }
            return true;
        }
    }
}
