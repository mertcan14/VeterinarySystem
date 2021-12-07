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
    public class HospitalCategoryManager : IHospitalCategoryService
    {
        IHospitalCategoryDal _hospitalCategoryDal;

        public HospitalCategoryManager(IHospitalCategoryDal hospitalCategoryDal)
        {
            _hospitalCategoryDal = hospitalCategoryDal;
        }

        [ValidationAspect(typeof(HospitalCategoryValidator))]
        public IResult Add(HospitalCategory hospitalCategory)
        {
            _hospitalCategoryDal.Add(hospitalCategory);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _hospitalCategoryDal.Delete(_hospitalCategoryDal.Get(h=> h.Id==id)) ;
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<HospitalCategory>> GetAll()
        {
            return new SuccessDataResult<List<HospitalCategory>>(Messages.ListedSuccess, _hospitalCategoryDal.GetAll());
        }

        public IDataResult<HospitalCategory> GetById(int id)
        {
            return new SuccessDataResult<HospitalCategory>(Messages.ListedSuccess, _hospitalCategoryDal.Get(h=> h.Id == id));
        }

        [ValidationAspect(typeof(HospitalCategoryValidator))]
        public IResult Update(HospitalCategory hospitalCategory)
        {
            _hospitalCategoryDal.Update(hospitalCategory);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
