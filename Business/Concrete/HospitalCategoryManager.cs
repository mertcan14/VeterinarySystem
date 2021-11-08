using Business.Abstract;
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

        public Result Add(HospitalCategory hospitalCategory)
        {
            _hospitalCategoryDal.Add(hospitalCategory);
            return new SuccessResult("Başarı ile eklendi.");
        }

        public Result Delete(int id)
        {
            _hospitalCategoryDal.Delete(_hospitalCategoryDal.Get(h=> h.Id==id)) ;
            return new SuccessResult("Başarı ile silindi.");
        }

        public Result GetAll()
        {
            return new SuccessDataResult<List<HospitalCategory>>("Başarı ile listelendi.", _hospitalCategoryDal.GetAll());
        }

        public Result GetById(int id)
        {
            return new SuccessDataResult<HospitalCategory>("Başarı ile getirildi.", _hospitalCategoryDal.Get(h=> h.Id == id));
        }

        public Result Update(HospitalCategory hospitalCategory)
        {
            _hospitalCategoryDal.Update(hospitalCategory);
            return new SuccessResult("başarı ile güncellendi.");
        }
    }
}
