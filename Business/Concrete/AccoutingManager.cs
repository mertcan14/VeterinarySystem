using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class AccoutingManager : IAccoutingService
    {
        IAccoutingDal _accoutingDal;

        public AccoutingManager(IAccoutingDal accoutingDal)
        {
            _accoutingDal = accoutingDal;
        }

        public IResult Get()
        {
            return new SuccessDataResult<Accouting>(Messages.ListedSuccess, _accoutingDal.GetAll().First());
        }
    }
}
