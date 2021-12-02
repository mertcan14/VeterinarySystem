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
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public IResult Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(int id)
        {
            _appointmentDal.Delete(_appointmentDal.Get(a => a.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IResult GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(Messages.ListedSuccess, _appointmentDal.GetAll());
        }

        public IResult GetById(int id)
        {
            return new SuccessDataResult<Appointment>(Messages.ListedSuccess, _appointmentDal.Get(a=> a.Id == id));
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
