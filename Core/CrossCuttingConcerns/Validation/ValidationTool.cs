using Core.Utilities.Results;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
                //string errorText = "";
                //for (int i = 0; i < result.Errors.Count; i++)
                //{
                //    errorText += i.ToString() + ": " +  result.Errors[i].ToString();
                //}
                //return new ErrorResult(errorText);
            }
            //return new SuccessResult();
        }
    }
}
