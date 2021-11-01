﻿using Business.Abstract;
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

        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult("Başarı ile eklendi");
        }

        public IResult Delete(int id)
        {
            _addressDal.Delete(_addressDal.Get(a=> a.Id == id));
            return new SuccessResult("Başarı ile silindi");
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Address>>("Başarı ile listelendi", _addressDal.GetAll());
        }

        public IResult GetByCityId(int id)
        {
            return new SuccessDataResult<List<Address>>("Başarı ile listelendi.", _addressDal.GetAll(a=>a.District.City.Id==id));
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Address>("Başarı ile getirildi.", _addressDal.Get(a=> a.Id == id));
        }

        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult("Başarı ile güncellendi");
        }
    }
}