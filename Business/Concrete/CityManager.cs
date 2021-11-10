using Business.Abstract;
using Business.Constants;
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

        public IResult Add(City city)
        {
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

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
