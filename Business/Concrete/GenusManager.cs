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
    public class GenusManager : IGenusService
    {
        IGenusDal _genusDal;

        public GenusManager(IGenusDal genusDal)
        {
            _genusDal = genusDal;
        }

        [ValidationAspect(typeof(GenusValidator))]
        public IResult Add(Genus genus)
        {
            _genusDal.Add(genus);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _genusDal.Delete(_genusDal.Get(g=> g.Id==id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Genus>> GetAll()
        {
            return new SuccessDataResult<List<Genus>>(Messages.ListedSuccess, _genusDal.GetAll());
        }

        public IDataResult<Genus> GetById(int id)
        {
            return new SuccessDataResult<Genus>(Messages.ListedSuccess, _genusDal.Get(g=> g.Id == id));
        }

        [ValidationAspect(typeof(GenusValidator))]
        public IResult Update(Genus genus)
        {
            _genusDal.Update(genus);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
