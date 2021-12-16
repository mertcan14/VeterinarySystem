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
    public class PetManager : IPetService
    {
        IPetDal _petDal;

        public PetManager(IPetDal petDal)
        {
            _petDal = petDal;
        }

        [ValidationAspect(typeof(PetValidator))]
        public IResult Add(Pet pet)
        {
            _petDal.Add(pet);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _petDal.Delete(_petDal.Get(p=> p.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Pet>> GetAll()
        {
            return new SuccessDataResult<List<Pet>>(Messages.ListedSuccess, _petDal.GetAll());
        }

        public IDataResult<List<Pet>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Pet>>(Messages.ListedSuccess, _petDal.GetAll(p=> p.CustomerId == customerId));
        }

        public IDataResult<List<PetDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<PetDetailDto>>(Messages.ListedSuccess, _petDal.GetAllPetDetail());
        }

        public IDataResult<Pet> GetById(int id)
        {
            return new SuccessDataResult<Pet>(Messages.ListedSuccess, _petDal.Get(p=> p.Id == id));
        }

        public IDataResult<PetDetailDto> GetDetailById(int id)
        {
            return new SuccessDataResult<PetDetailDto>(Messages.ListedSuccess, _petDal.GetPetDetail(id));
        }

        [ValidationAspect(typeof(PetValidator))]
        public IResult Update(Pet pet)
        {
            _petDal.Update(pet);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
