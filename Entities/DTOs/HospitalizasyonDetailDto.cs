using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class HospitalizasyonDetailDto
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int HospitalizasyonBedId { get; set; }
        public string HospitalizasyonBedName { get; set; }
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
