using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IResult Add(Address address);
        IResult GetById(int id);
        IResult GetAll();
        IResult Update(Address address);
        IResult Delete(int id);
        IResult GetByCityId(int id);
    }
}
