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
    public class GradeManager : IGradeService
    {
        IGradeDal _gradeDal;

        public GradeManager(IGradeDal gradeDal)
        {
            _gradeDal = gradeDal;
        }
        [ValidationAspect(typeof(GradeValidator))]
        public IResult Add(Grade grade)
        {
            _gradeDal.Add(grade);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _gradeDal.Delete(_gradeDal.Get(g=> g.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Grade>>(Messages.ListedSuccess, _gradeDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Grade>(Messages.ListedSuccess,_gradeDal.Get(g=> g.Id == id));
        }

        [ValidationAspect(typeof(GradeValidator))]
        public IResult Update(Grade grade)
        {
            _gradeDal.Update(grade);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
