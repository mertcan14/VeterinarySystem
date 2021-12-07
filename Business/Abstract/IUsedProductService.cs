using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsedProductService
    {
        IResult Add(UsedProduct usedProduct);
        IResult Update(UsedProduct usedProduct);
        IDataResult<List<UsedProduct>> GetAll();
        IDataResult<UsedProduct> GetById(int id);
        IResult Delete(int id);
    }
}
