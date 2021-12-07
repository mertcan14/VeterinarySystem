using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IResult Add(District district);
        IDataResult<District> GetById(int id);
        IDataResult<List<District>> GetAll();
        IResult Update(District district);
        IResult Delete(int id);
        IDataResult<List<District>> GetByCityId(int id);
    }
}
