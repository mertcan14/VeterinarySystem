using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISaleDal : IEntityRepository<Sale>
    {
        List<SaleDetailDto> getAllDetail(Expression<Func<SaleDetailDto, bool>> filter = null);
    }
}
