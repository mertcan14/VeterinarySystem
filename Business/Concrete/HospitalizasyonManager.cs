using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HospitalizasyonManager : IHospitalizasyonService
    {
        IHospitalizasyonDal _hospitalizasyonDal;

        public HospitalizasyonManager(IHospitalizasyonDal hospitalizasyonDal)
        {
            _hospitalizasyonDal = hospitalizasyonDal;
        }

        public Result Add(Hospitalizasyon hospitalizasyon)
        {
            _hospitalizasyonDal.Add(hospitalizasyon);
            return new SuccessResult("Başarı ile eklendi.");
        }

        public Result BedAvailable(CheckBedAvailable checkBedAvailable)
        {
            var result = _hospitalizasyonDal.BedAvailable(checkBedAvailable.EntryDate, checkBedAvailable.ReleaseDate, checkBedAvailable.BedCategoryId);
            return new SuccessDataResult<List<HospitalizasyonBed>>("Başarı ile listelendi.", result);
        }

        public Result Delete(int id)
        {
            _hospitalizasyonDal.Delete(_hospitalizasyonDal.Get(h=> h.Id == id));
            return new SuccessResult("Başarı ile silindi.");
        }

        public Result GetAll()
        {
            return new SuccessDataResult<List<Hospitalizasyon>>("Başarı ile listelendi.", _hospitalizasyonDal.GetAll());
        }

        public Result GetById(int id)
        {
            return new SuccessDataResult<Hospitalizasyon>("Başarı ile getirildi.", _hospitalizasyonDal.Get(h=> h.Id == id));
        }

        public Result Update(Hospitalizasyon hospitalizasyon)
        {
            _hospitalizasyonDal.Update(hospitalizasyon);
            return new SuccessResult("Başarı ile güncellendi.");
        }
    }
}
