using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPetService 
    {
        IResult Add(Pet pet);
        IResult Update(Pet pet);
        IResult GetAll();
        IResult GetById(int id);
        IResult Delete(int id);
    }
}
