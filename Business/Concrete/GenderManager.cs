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

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Gender>>(Messages.ListedSuccess, _genderDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Gender>(Messages.ListedSuccess, _genderDal.Get(g => g.Id == id));
        }
    }
}
