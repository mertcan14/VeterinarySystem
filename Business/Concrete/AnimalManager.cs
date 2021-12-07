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
    public class AnimalManager : IAnimalService
    {
        IAnimalDal _animalDal;

        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IResult Add(Animal animal)
        {
            _animalDal.Add(animal);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _animalDal.Delete(_animalDal.Get(a=> a.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Animal>> GetAll()
        {
            return new SuccessDataResult<List<Animal>>(Messages.ListedSuccess, _animalDal.GetAll());
        }

        public IDataResult<Animal> GetById(int id)
        {
            return new SuccessDataResult<Animal>(Messages.ListedSuccess, _animalDal.Get(a=> a.Id == id)) ;
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IResult Update(Animal animal)
        {
            _animalDal.Update(animal);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
