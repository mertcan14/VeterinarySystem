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
        IResult GetById(int id);
        IResult GetAll();
        IResult Update(Animal animal);
        IResult Delete(int id);
    }
}
