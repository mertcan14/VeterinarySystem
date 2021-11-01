using Business.Abstract;
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
            return new SuccessResult("Başarı ile eklendi");
        }

        public IResult Delete(int id)
        {
            _cityDal.Delete(_cityDal.Get(c=> c.Id == id));
            return new SuccessResult("Başarı ile silindi.");
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<City>>("Başarı ile listelendi", _cityDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<City>("Başarı ile getirildi",_cityDal.Get(c => c.Id == id));
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult("Başarı ile Güncellendi.");
        }
    }
}
