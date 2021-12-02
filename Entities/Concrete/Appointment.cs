using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AddedDate { get; set; }

        public Pet Pet { get; set; }

    }
}
