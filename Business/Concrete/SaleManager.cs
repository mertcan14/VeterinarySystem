using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;

        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }

        public IResult Add(Sale sale)
        {
            _saleDal.Add(sale);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _saleDal.Delete(_saleDal.Get(s=> s.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Sale>> GetAll()
        {
            return new SuccessDataResult<List<Sale>>(Messages.ListedSuccess, _saleDal.GetAll());
        }

        public IDataResult<List<SaleDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<SaleDetailDto>>(Messages.ListedSuccess, _saleDal.getAllDetail());
        }

        public IDataResult<Sale> GetById(int id)
        {
            return new SuccessDataResult<Sale>(Messages.ListedSuccess, _saleDal.Get(s => s.Id == id));
        }

        public IResult Update(Sale sale)
        {
            _saleDal.Update(sale);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
