using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHospitalCategoryService
    {
        IResult Add(HospitalCategory hospitalCategory);
        IResult Update(HospitalCategory hospitalCategory);
        IResult Delete(int id);
        IDataResult<HospitalCategory> GetById(int id);
        IDataResult<List<HospitalCategory>> GetAll();
    }
}
