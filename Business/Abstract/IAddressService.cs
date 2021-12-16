using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IDataResult<List<AddressDetailDto>> GetDetailByUserId(int userId);
        IResult Update(Address address);
        IResult Delete(int id);
        IDataResult<List<Address>> GetByCityId(int id);
    }
}
