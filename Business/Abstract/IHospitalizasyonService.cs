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
        Result Add(Hospitalizasyon hospitalizasyon);
        Result Update(Hospitalizasyon hospitalizasyon);
        Result Delete(int id);
        Result GetById(int id);
        Result GetAll();
        Result BedAvailable(CheckBedAvailable checkBedAvailable);
    }
}
