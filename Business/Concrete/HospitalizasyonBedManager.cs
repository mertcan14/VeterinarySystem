using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HospitalizasyonBedManager : IHospitalizasyonBedService
    {
        IHospitalizasyonBedDal _hospitalizasyonBedDal;

        public HospitalizasyonBedManager(IHospitalizasyonBedDal hospitalizasyonBedDal)
        {
            _hospitalizasyonBedDal = hospitalizasyonBedDal;
        }

        public Result Add(HospitalizasyonBed hospitalizasyonBed)
        {
            _hospitalizasyonBedDal.Add(hospitalizasyonBed);
            return new SuccessResult("Başarı ile eklendi.");
        }

        public Result Delete(int id)
        {
            _hospitalizasyonBedDal.Delete(_hospitalizasyonBedDal.Get(h=> h.Id == id));
            return new SuccessResult("Başarı ile silindi.");
        }

        public Result GetAll()
        {
            return new SuccessDataResult<List<HospitalizasyonBed>>("Başarı ile listelendi.", _hospitalizasyonBedDal.GetAll());
        }

        public Result GetById(int id)
        {
            return new SuccessDataResult<HospitalizasyonBed>("Başarı ile getirildi.", _hospitalizasyonBedDal.Get(h=> h.Id == id));
        }

        public Result Update(HospitalizasyonBed hospitalizasyonBed)
        {
            _hospitalizasyonBedDal.Update(hospitalizasyonBed);
            return new SuccessResult("Başarı ile güncellendi.");
        }
    }
}
