using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAddressDal:IEntityRepository<Address>
    {
        List<AddressDetailDto> GetAllDetail(Expression<Func<AddressDetailDto, bool>> filter = null);
    }
}
