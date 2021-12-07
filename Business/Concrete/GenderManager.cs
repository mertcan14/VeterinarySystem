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
    public class GenderManager : IGenderService
    {
        IGenderDal _genderDal;

        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

        public IDataResult<List<Gender>> GetAll()
        {
            return new SuccessDataResult<List<Gender>>(Messages.ListedSuccess, _genderDal.GetAll());
        }

        public IDataResult<Gender> GetById(int id)
        {
            return new SuccessDataResult<Gender>(Messages.ListedSuccess, _genderDal.Get(g => g.Id == id));
        }
    }
}
