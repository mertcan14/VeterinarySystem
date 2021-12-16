using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService 
    {
        IResult Add(Product product);
        IResult Update(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetByCategoryId(int id);
        IDataResult<Product> GetById(int id);
        IResult Delete(int id);

    }
}
