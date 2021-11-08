using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Hospitalizasyon:IEntity
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public HospitalizasyonBed HospitalizasyonBed { get; set; }
    }
}
