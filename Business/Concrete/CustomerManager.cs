using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _customerDal.Delete(_customerDal.Get(c => c.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(Messages.ListedSuccess, _customerDal.GetAll());
        }

        public IDataResult<List<CustomerDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(Messages.ListedSuccess, _customerDal.getAllCustomerDetailDto());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(Messages.ListedSuccess, _customerDal.Get(c => c.Id == id));
        }

        public IDataResult<CustomerDetailDto> GetDetailById(int id)
        {
            return new SuccessDataResult<CustomerDetailDto>(Messages.ListedSuccess, _customerDal.getCustomerDetailDtoById(id));
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
