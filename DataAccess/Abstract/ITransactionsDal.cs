using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITransactionsDal : IEntityRepository<Transactions>
    {
        List<TransactionsDetailDto> getAllDetail(Expression<Func<TransactionsDetailDto, bool>> filter = null);
    }
}
