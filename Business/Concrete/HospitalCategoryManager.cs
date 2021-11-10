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
    public class HospitalCategoryManager : IHospitalCategoryService
    {
        IHospitalCategoryDal _hospitalCategoryDal;

        public HospitalCategoryManager(IHospitalCategoryDal hospitalCategoryDal)
        {
            _hospitalCategoryDal = hospitalCategoryDal;
        }

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

        public IResult GetAll()
        {
            return new SuccessDataResult<List<HospitalCategory>>(Messages.ListedSuccess, _hospitalCategoryDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<HospitalCategory>(Messages.ListedSuccess, _hospitalCategoryDal.Get(h=> h.Id == id));
        }

        public IResult Update(HospitalCategory hospitalCategory)
        {
            _hospitalCategoryDal.Update(hospitalCategory);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
