using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IInComeService
    {
        IResult Add(InCome ınCome);
        IResult Update(InCome ınCome);
        IResult Delete(int id);
        IResult DeleteByDate(DateTime date);
        IDataResult<InCome> GetById(int id);
        IDataResult<InCome> GetByAddedDate(DateTime date);
        IResult GetAll();
    }
}
