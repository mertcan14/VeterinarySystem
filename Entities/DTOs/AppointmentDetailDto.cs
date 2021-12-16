using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AppointmentDetailDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentExitDate { get; set; }
        public string PetName { get; set; }
        public string? MicrochipNumber { get; set; }
        public int PetBirthYear { get; set; }
        public string PetColor { get; set; }
    }
}
