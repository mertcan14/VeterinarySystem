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
    public class InComeManager : IInComeService
    {
        IInComeDal _inComeDal;

        public InComeManager(IInComeDal inComeDal)
        {
            _inComeDal = inComeDal;
        }

        [ValidationAspect(typeof(InComeValidator))]
        public IResult Add(InCome inCome)
        {
            _inComeDal.Add(inCome);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _inComeDal.Delete(_inComeDal.Get(i=> i.Id==id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult DeleteByDate(DateTime date)
        {
            _inComeDal.Delete(_inComeDal.Get(i => i.AddedDate == date));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<InCome>>(Messages.ListedSuccess, _inComeDal.GetAll());
        }

        public IDataResult<InCome> GetByAddedDate(DateTime date)
        {
            return new SuccessDataResult<InCome>(Messages.ListedSuccess, _inComeDal.Get(i => i.AddedDate == date));
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<InCome>(Messages.ListedSuccess, _inComeDal.Get(i=> i.Id==id));
        }

        [ValidationAspect(typeof(InComeValidator))]
        public IResult Update(InCome inCome)
        {
            _inComeDal.Update(inCome);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
