using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnimalService
    {
        IResult Add(Animal animal);
        IDataResult<Animal> GetById(int id);
        IDataResult<List<Animal>> GetAll();
        IResult Update(Animal animal);
        IResult Delete(int id);
    }
}
