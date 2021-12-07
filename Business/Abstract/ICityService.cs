using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICityService
    {
        IResult Add(City city);
        IDataResult<City> GetById(int id);
        IDataResult<List<City>> GetAll();
        IResult Update(City city);
        IResult Delete(int id);
    }
}
