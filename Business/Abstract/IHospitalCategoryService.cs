using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHospitalCategoryService
    {
        Result Add(HospitalCategory hospitalCategory);
        Result Update(HospitalCategory hospitalCategory);
        Result Delete(int id);
        Result GetById(int id);
        Result GetAll();
    }
}
