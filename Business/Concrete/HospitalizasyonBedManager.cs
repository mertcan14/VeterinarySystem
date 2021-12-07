using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
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

        [ValidationAspect(typeof(HospitalizasyonBedValidator))]
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

        public IDataResult<List<HospitalizasyonBed>> GetAll()
        {
            return new SuccessDataResult<List<HospitalizasyonBed>>(Messages.ListedSuccess, _hospitalizasyonBedDal.GetAll());
        }

        public IDataResult<HospitalizasyonBed> GetById(int id)
        {
            return new SuccessDataResult<HospitalizasyonBed>(Messages.ListedSuccess, _hospitalizasyonBedDal.Get(h=> h.Id == id));
        }

        public IDataResult<List<HospitalizasyonBed>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<HospitalizasyonBed>>(Messages.ListedSuccess, _hospitalizasyonBedDal.GetAll(h=> h.HospitalCategory.Id==categoryId));
        }

        [ValidationAspect(typeof(HospitalizasyonBedValidator))]
        public IResult Update(HospitalizasyonBed hospitalizasyonBed)
        {
            _hospitalizasyonBedDal.Update(hospitalizasyonBed);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
