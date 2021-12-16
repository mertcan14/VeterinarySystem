using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

            if (_appointmentDal.AppointmentAvailable(appointment.AppointmentDate,appointment.AppointmentExitDate))
            {
                _appointmentDal.Add(appointment);
                return new SuccessResult(Messages.AddedSuccess);
            }

            return new ErrorResult(Messages.AddedError);
        }

        public IResult Delete(int id)
        {
            _appointmentDal.Delete(_appointmentDal.Get(a => a.Id == id));
            return new SuccessResult(Messages.DeletedSuccess);
        }

        public IDataResult<List<Appointment>> GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(Messages.ListedSuccess, _appointmentDal.GetAll());
        }

        public IDataResult<List<Appointment>> GetAllByPetId(int petId)
        {
            return new SuccessDataResult<List<Appointment>>(Messages.ListedSuccess, _appointmentDal.GetAll(a=> a.PetId==petId)); 
        }

        public IDataResult<Appointment> GetById(int id)
        {
            return new SuccessDataResult<Appointment>(Messages.ListedSuccess, _appointmentDal.Get(a=> a.Id == id));
        }

        public IDataResult<List<AppointmentDetailDto>> GetByNow()
        {
            DateTime now =  DateTime.Now;
            var result = _appointmentDal.GetAppointmentDetailDto(a => a.AppointmentDate.Year == now.Year && a.AppointmentDate.Day == now.Day && a.AppointmentDate.Month == now.Month);
            return new SuccessDataResult<List<AppointmentDetailDto>>(Messages.ListedSuccess, result);
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
