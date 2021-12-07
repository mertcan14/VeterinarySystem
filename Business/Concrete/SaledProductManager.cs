using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SaledProductManager : ISaledProductService
    {
        ISaledProductDal _saledProductDal;

        public SaledProductManager(ISaledProductDal saledProductDal)
        {
            _saledProductDal = saledProductDal;
        }

        public IResult Add(SaledProduct saledProduct)
        {
            _saledProductDal.Add(saledProduct);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _saledProductDal.Delete(_saledProductDal.Get(s => s.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<SaledProduct>> GetAll()
        {
            return new SuccessDataResult<List<SaledProduct>>(Messages.ListedSuccess, _saledProductDal.GetAll());
        }

        public IDataResult<List<SaledProduct>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<SaledProduct>>(Messages.ListedSuccess, _saledProductDal.GetAll(s=>s.Product.Category.Id == categoryId));
        }

        public IDataResult<SaledProduct> GetById(int id)
        {
            return new SuccessDataResult<SaledProduct>(Messages.ListedSuccess, _saledProductDal.Get(s=> s.Id == id));
        }

        public IResult Update(SaledProduct saledProduct)
        {
            _saledProductDal.Update(saledProduct);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
