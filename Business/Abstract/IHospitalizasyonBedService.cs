using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHospitalizasyonBedService 
    {
        Result Add(HospitalizasyonBed hospitalizasyonBed);
        Result Update(HospitalizasyonBed hospitalizasyonBed);
        Result Delete(int id);
        Result GetById(int id);
        Result GetAll();
    }
}
