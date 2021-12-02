using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService 
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult GetAll();
        IResult GetById(int id);
        IResult Delete(int id);
    }
}
