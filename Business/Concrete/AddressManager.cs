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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        [ValidationAspect(typeof(AddressValidator))]
        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _addressDal.Delete(_addressDal.Get(a=> a.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(Messages.ListedSuccess, _addressDal.GetAll());
        }

        public IDataResult<List<Address>> GetByCityId(int id)
        {
            return new SuccessDataResult<List<Address>>(Messages.ListedSuccess, _addressDal.GetAll(a=>a.District.City.Id==id));
        }

        public IDataResult<Address> GetById(int id)
        {
            return new SuccessDataResult<Address>(Messages.ListedSuccess, _addressDal.Get(a=> a.Id == id));
        }

        [ValidationAspect(typeof(AddressValidator))]
        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
