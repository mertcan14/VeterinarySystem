using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExpenseService
    {
        IResult Add(Expense expense);
        IResult Update(Expense expense);
        IResult Delete(int id);
        IDataResult<Expense> GetById(int id);
        IDataResult<List<Expense>> GetAll();
    }
}
