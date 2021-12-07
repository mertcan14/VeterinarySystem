using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaledProductService
    {
        IResult Add(SaledProduct saledProduct);
        IResult Update(SaledProduct saledProduct);
        IDataResult<List<SaledProduct>> GetAll();
        IDataResult<List<SaledProduct>> GetByCategoryId(int categoryId);
        IDataResult<SaledProduct> GetById(int id);
        IResult Delete(int id);
    }
}
