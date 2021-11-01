﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGradeService
    {
        IResult Add(Grade grade);
        IResult GetById(int id);
        IResult GetAll();
        IResult Update(Grade grade);
        IResult Delete(int id);
    }
}