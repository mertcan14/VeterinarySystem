using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Company:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Accouting Accouting { get; set; }
        public List<HospitalizasyonBed> HospitalizasyonBeds { get; set; }
    }
}
