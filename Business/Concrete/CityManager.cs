using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        [ValidationAspect(typeof(CityValidator))]
        public IResult Add(City city)
        {
            //var result = ValidationTool.Validate(new CityValidator(), city);

            //if (!result.Success)
            //{
             //   return result;
            //}

            _cityDal.Add(city);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _cityDal.Delete(_cityDal.Get(c=> c.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<City>>(Messages.ListedSuccess, _cityDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<City>(Messages.ListedSuccess,_cityDal.Get(c => c.Id == id));
        }

        [ValidationAspect(typeof(CityValidator))]
        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
