﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService 
    {
        IResult Add(Product product);
        IResult Update(Product product);
        IResult GetAll();
        IResult GetById(int id);
        IResult Delete(int id);

    }
}
