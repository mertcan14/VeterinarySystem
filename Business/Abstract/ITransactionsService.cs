using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITransactionsService
    {
        IResult Add(Transactions transactions);
        IResult Update(Transactions transactions);
        IDataResult<List<Transactions>> GetAll();
        IDataResult<Transactions> GetById(int id);
        IResult Delete(int id);
    }
}
