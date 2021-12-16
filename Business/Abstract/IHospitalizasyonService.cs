using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHospitalizasyonService
    {
        IResult Add(Hospitalizasyon hospitalizasyon);
        IResult Update(Hospitalizasyon hospitalizasyon);
        IResult Delete(int id);
        IDataResult<Hospitalizasyon> GetById(int id);
        IDataResult<List<Hospitalizasyon>> GetAll();
        IDataResult<List<HospitalizasyonBed>> BedAvailable(CheckBedAvailable checkBedAvailable);
        IDataResult<List<HospitalizasyonBed>> BedBusy();
    }
}
