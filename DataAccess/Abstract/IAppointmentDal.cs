using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAppointmentDal : IEntityRepository<Appointment>
    {
        bool AppointmentAvailable(DateTime appointmentDate, DateTime appointmentExitDate);
        List<AppointmentDetailDto> GetAppointmentDetailDto(Expression<Func<AppointmentDetailDto, bool>> filter = null);
    }
}
