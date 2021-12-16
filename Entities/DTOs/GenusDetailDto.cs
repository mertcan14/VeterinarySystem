using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class GenusDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
    }
}
