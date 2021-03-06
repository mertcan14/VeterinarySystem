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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.AddedSuccess);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IDataResult<int> AddReturnId(User user)
        {
            return new SuccessDataResult<int>(Messages.AddedSuccess, _userDal.AddReturnId(user));
        }

        public IResult Delete(int id)
        {
            _userDal.Delete(_userDal.Get(u => u.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(Messages.ListedSuccess, _userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(Messages.ListedSuccess, _userDal.Get(u=> u.Id == id));
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
