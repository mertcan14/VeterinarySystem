using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IResult Add(Company company);
        IResult Update(Company company);
        IResult Delete(int id);
        IDataResult<Company> GetById(int id);
        IDataResult<List<Company>> GetAll();
    }
}
