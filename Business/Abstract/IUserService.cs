using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IDataResult<User> GetById(int id);
        IResult Delete(int id);
        IDataResult<List<User>> GetAll();
        IDataResult<int> AddReturnId(User user);
    }
}
