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
        IResult GetById(int id);
        IResult GetAll();
        IResult Update(District district);
        IResult Delete(int id);
        IResult GetByCityId(int id);
    }
}
