using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
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

        [ValidationAspect(typeof(HospitalizasyonValidator))]
        public IResult Add(Hospitalizasyon hospitalizasyon)
        {
            _hospitalizasyonDal.Add(hospitalizasyon);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IDataResult<List<HospitalizasyonBed>> BedAvailable(CheckBedAvailable checkBedAvailable)
        {
            var result = _hospitalizasyonDal.BedAvailable(checkBedAvailable.EntryDate, checkBedAvailable.ReleaseDate, checkBedAvailable.BedCategoryId);
            return new SuccessDataResult<List<HospitalizasyonBed>>(Messages.ListedSuccess, result);
        }

        public IDataResult<List<HospitalizasyonBed>> BedBusy()
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            _hospitalizasyonDal.Delete(_hospitalizasyonDal.Get(h=> h.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Hospitalizasyon>> GetAll()
        {
            return new SuccessDataResult<List<Hospitalizasyon>>(Messages.ListedSuccess, _hospitalizasyonDal.GetAll());
        }

        public IDataResult<Hospitalizasyon> GetById(int id)
        {
            return new SuccessDataResult<Hospitalizasyon>(Messages.ListedSuccess, _hospitalizasyonDal.Get(h=> h.Id == id));
        }

        [ValidationAspect(typeof(HospitalizasyonValidator))]
        public IResult Update(Hospitalizasyon hospitalizasyon)
        {
            _hospitalizasyonDal.Update(hospitalizasyon);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
