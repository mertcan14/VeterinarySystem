using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CheckBedAvailable
    {
        public int BedCategoryId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
