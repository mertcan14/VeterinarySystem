using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsedProductManager : IUsedProductService
    {
        IUsedProductDal _usedProductDal;

        public UsedProductManager(IUsedProductDal usedProductDal)
        {
            _usedProductDal = usedProductDal;
        }

        [ValidationAspect(typeof(UsedProductValidator))]
        public IResult Add(UsedProduct usedProduct)
        {
            _usedProductDal.Add(usedProduct);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _usedProductDal.Delete(_usedProductDal.Get(u => u.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<UsedProduct>> GetAll()
        {
            return new SuccessDataResult<List<UsedProduct>>(Messages.ListedSuccess, _usedProductDal.GetAll());
        }

        public IDataResult<UsedProduct> GetById(int id)
        {
            return new SuccessDataResult<UsedProduct>(Messages.ListedSuccess, _usedProductDal.Get(u => u.Id == id));
        }

        [ValidationAspect(typeof(UsedProductValidator))]
        public IResult Update(UsedProduct usedProduct)
        {
            _usedProductDal.Update(usedProduct);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
