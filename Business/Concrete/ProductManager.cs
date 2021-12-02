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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _productDal.Delete(_productDal.Get(p=>p.Id ==id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Product>>(Messages.ListedSuccess, _productDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Product>(Messages.ListedSuccess, _productDal.Get(p=>p.Id == id));
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
