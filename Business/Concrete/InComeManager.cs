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
    public class InComeManager : IInComeService
    {
        IInComeDal _inComeDal;

        public InComeManager(IInComeDal inComeDal)
        {
            _inComeDal = inComeDal;
        }

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

        public IResult GetAll()
        {
            return new SuccessDataResult<List<InCome>>(Messages.ListedSuccess, _inComeDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<InCome>(Messages.ListedSuccess, _inComeDal.Get(i=> i.Id==id));
        }

        public IResult Update(InCome inCome)
        {
            _inComeDal.Update(inCome);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
