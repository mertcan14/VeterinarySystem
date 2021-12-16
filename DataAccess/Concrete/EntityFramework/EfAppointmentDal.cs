using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using System.Linq.Expressions;

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

        public List<AppointmentDetailDto> GetAppointmentDetailDto(Expression<Func<AppointmentDetailDto, bool>> filter = null)
        {
            using (VetContext context = new VetContext())
            {
                var result = from ap in context.appointments
                             join pe in context.pets
                             on ap.PetId equals pe.Id
                             select new AppointmentDetailDto
                             {
                                 Id = ap.Id,
                                 AppointmentDate = ap.AppointmentDate,
                                 AppointmentExitDate = ap.AppointmentExitDate,
                                 Definition = ap.Definition,
                                 MicrochipNumber = pe.MicrochipNumber,
                                 PetBirthYear = pe.BirthYear,
                                 PetColor = pe.Color,
                                 PetName = pe.Name,
                             };
                if (filter is null)
                {
                    return result.ToList();
                }
                else
                {
                    return result.Where(filter).ToList();
                }
            }
        }
    }
}
