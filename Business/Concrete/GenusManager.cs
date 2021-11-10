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
    public class GenusManager : IGenusService
    {
        IGenusDal _genusDal;

        public GenusManager(IGenusDal genusDal)
        {
            _genusDal = genusDal;
        }

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

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Genus>>(Messages.ListedSuccess, _genusDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Genus>(Messages.ListedSuccess, _genusDal.Get(g=> g.Id == id));
        }

        public IResult Update(Genus genus)
        {
            _genusDal.Update(genus);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
