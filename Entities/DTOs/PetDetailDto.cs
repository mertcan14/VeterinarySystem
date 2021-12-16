using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PetDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? MicrochipNumber { get; set; }
        public int BirthYear { get; set; }
        public string Color { get; set; }
        public string GenusName { get; set; }
        public string CustomerName { get; set; }
        public string GenderName { get; set; }
    }
}
