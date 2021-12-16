using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPetService 
    {
        IResult Add(Pet pet);
        IResult Update(Pet pet);
        IDataResult<List<Pet>> GetAll();
        IDataResult<List<Pet>> GetAllByCustomerId(int customerId);
        IDataResult<PetDetailDto> GetDetailById(int id);
        IDataResult<List<PetDetailDto>> GetAllDetail();
        IDataResult<Pet> GetById(int id);
        IResult Delete(int id);
    }
}
