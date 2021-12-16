using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HospitalizasyonBed:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int HospitalCategoryId { get; set; }
        public HospitalCategory HospitalCategory { get; set; }
        public List<Hospitalizasyon> Hospitalizasyons { get; set; }
    }
}
