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
        IDataResult<Address> GetById(int id);
        IDataResult<List<Address>> GetAll();
        IResult Update(Address address);
        IResult Delete(int id);
        IDataResult<List<Address>> GetByCityId(int id);
    }
}
