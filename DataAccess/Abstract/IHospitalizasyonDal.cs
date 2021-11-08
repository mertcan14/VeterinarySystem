using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IHospitalizasyonDal:IEntityRepository<Hospitalizasyon>
    {
        List<HospitalizasyonBed> BedAvailable(DateTime entryDate, DateTime releaseDate, int bedCategoryId);
    }
}
