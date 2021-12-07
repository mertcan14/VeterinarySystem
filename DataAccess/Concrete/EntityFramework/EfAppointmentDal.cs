using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAppointmentDal : EfEntityRepositoryBase<Appointment, VetContext>, IAppointmentDal
    {
        public bool AppointmentAvailable(DateTime appointmentDate, DateTime appointmentExitDate)
        {
            using (VetContext context = new VetContext())
            {
                var result1 = from ap in context.appointments
                              where (ap.AppointmentDate <= appointmentDate && appointmentDate <= ap.AppointmentExitDate) || (ap.AppointmentDate <= appointmentExitDate && appointmentExitDate <= ap.AppointmentExitDate)
                              select ap;
                if (result1.Count()>0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
