using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGenusService
    {
        IResult Add(Genus genus);
        IDataResult<Genus> GetById(int id);
        IDataResult<List<Genus>> GetAll();
        IResult Update(Genus genus);
        IResult Delete(int id);
    }
}
