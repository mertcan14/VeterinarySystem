using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public IResult Add(District district)
        {
            _districtDal.Add(district);
            return new SuccessResult("Başarı ile eklendi");
        }

        public IResult Delete(int id)
        {
            _districtDal.Delete(_districtDal.Get(c=> c.Id==id));
            return new SuccessResult("Başarı ile silindi");
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<District>>("Başarı ile listelendi", _districtDal.GetAll());
        }

        public IResult GetByCityId(int id)
        {
            return new SuccessDataResult<List<District>>("Başarı ile getirildi", _districtDal.GetAll(d=> d.City.Id == id));
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<District>("Başarı ile eklendi", _districtDal.Get(c=> c.Id == id));
        }

        public IResult Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult("Başarı ile güncellendi");
        }
    }
}
