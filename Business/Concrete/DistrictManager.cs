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
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _districtDal.Delete(_districtDal.Get(c=> c.Id==id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<District>>(Messages.ListedSuccess, _districtDal.GetAll());
        }

        public IResult GetByCityId(int id)
        {
            return new SuccessDataResult<List<District>>(Messages.ListedSuccess, _districtDal.GetAll(d=> d.City.Id == id));
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<District>(Messages.ListedSuccess, _districtDal.Get(c=> c.Id == id));
        }

        public IResult Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
