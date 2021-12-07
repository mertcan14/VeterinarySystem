﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAppointmentService 
    {
        IResult Add(Appointment appointment);
        IResult Update(Appointment appointment);
        IDataResult<List<Appointment>> GetAll();
        IDataResult<List<Appointment>> GetByNow();
        IDataResult<Appointment> GetById(int id);
        IResult Delete(int id);
    }
}
