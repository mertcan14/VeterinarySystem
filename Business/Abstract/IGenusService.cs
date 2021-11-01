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
        IResult GetById(int id);
        IResult GetAll();
        IResult Update(Genus genus);
        IResult Delete(int id);
    }
}
