using Business.Abstract;
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

        public IResult Add(Animal animal)
        {
            _animalDal.Add(animal);
            return new SuccessResult("Başarı ile eklendi.");
        }

        public IResult Delete(int id)
        {
            _animalDal.Delete(_animalDal.Get(a=> a.Id == id));
            return new SuccessResult("Başarı ile silindi.");
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Animal>>("Başarı ile listelendi.", _animalDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Animal>("Başarı ile getirildi.", _animalDal.Get(a=> a.Id == id)) ;
        }

        public IResult Update(Animal animal)
        {
            _animalDal.Update(animal);
            return new SuccessResult("Başarı ile güncellendi.");
        }
    }
}
