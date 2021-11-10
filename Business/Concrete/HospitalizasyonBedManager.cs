using Business.Abstract;
using Business.Constants;
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

        public IResult Add(HospitalizasyonBed hospitalizasyonBed)
        {
            _hospitalizasyonBedDal.Add(hospitalizasyonBed);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _hospitalizasyonBedDal.Delete(_hospitalizasyonBedDal.Get(h=> h.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<HospitalizasyonBed>>(Messages.ListedSuccess, _hospitalizasyonBedDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<HospitalizasyonBed>(Messages.ListedSuccess, _hospitalizasyonBedDal.Get(h=> h.Id == id));
        }

        public IResult GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<HospitalizasyonBed>>(Messages.ListedSuccess, _hospitalizasyonBedDal.GetAll(h=> h.HospitalCategory.Id==categoryId));
        }

        public IResult Update(HospitalizasyonBed hospitalizasyonBed)
        {
            _hospitalizasyonBedDal.Update(hospitalizasyonBed);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
