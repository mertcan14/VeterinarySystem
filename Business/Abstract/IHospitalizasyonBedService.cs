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
        IResult GetById(int id);
        IResult GetAll();
        IResult GetByCategoryId(int categoryId);
    }
}
