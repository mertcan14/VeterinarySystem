using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        Result Add(Company company);
        Result Update(Company company);
        Result Delete(int id);
        Result GetById(int id);
        Result GetAll();
    }
}
