using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAnimalDal:IEntityRepository<Animal>
    {
        List<AnimalDetailDto> GetAllAnimalDetail(Expression<Func<AnimalDetailDto, bool>> filter = null);
    }
}
