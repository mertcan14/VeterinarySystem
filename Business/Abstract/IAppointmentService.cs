using Core.Utilities.Results;
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
        IResult GetAll();
        IResult GetById(int id);
        IResult Delete(int id);
    }
}
