using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHospitalizasyonBedService 
    {
        IResult Add(HospitalizasyonBed hospitalizasyonBed);
        IResult Update(HospitalizasyonBed hospitalizasyonBed);
        IResult Delete(int id);
        IDataResult<HospitalizasyonBed> GetById(int id);
        IDataResult<List<HospitalizasyonBed>> GetAll();
        IDataResult<List<HospitalizasyonBed>> GetByCategoryId(int categoryId);
    }
}
