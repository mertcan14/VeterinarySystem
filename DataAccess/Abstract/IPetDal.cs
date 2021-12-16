using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPetDal : IEntityRepository<Pet>
    {
        PetDetailDto GetPetDetail(int id);
        List<PetDetailDto> GetAllPetDetail(Expression<Func<PetDetailDto, bool>> filter = null);
    }
}
