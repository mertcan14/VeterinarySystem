using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
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

        [ValidationAspect(typeof(DistrictValidator))]
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

        public IDataResult<List<District>> GetAll()
        {
            return new SuccessDataResult<List<District>>(Messages.ListedSuccess, _districtDal.GetAll());
        }

        public IDataResult<List<District>> GetByCityId(int id)
        {
            return new SuccessDataResult<List<District>>(Messages.ListedSuccess, _districtDal.GetAll(d=> d.City.Id == id));
        }

        public IDataResult<District> GetById(int id)
        {
            return new SuccessDataResult<District>(Messages.ListedSuccess, _districtDal.Get(c=> c.Id == id));
        }

        [ValidationAspect(typeof(DistrictValidator))]
        public IResult Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
