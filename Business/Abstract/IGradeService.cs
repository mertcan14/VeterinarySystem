using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGradeService
    {
        IResult Add(Grade grade);
        IDataResult<Grade> GetById(int id);
        IDataResult<List<Grade>> GetAll();
        IResult Update(Grade grade);
        IResult Delete(int id);
    }
}
