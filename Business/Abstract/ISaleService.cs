using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaleService 
    {
        IResult Add(Sale sale);
        IResult Update(Sale sale);
        IResult Delete(int id);
        IDataResult<List<Sale>> GetAll();
        IDataResult<List<SaleDetailDto>> GetAllDetail();
        IDataResult<Sale> GetById(int id);

    }
}
