using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Pet : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? MicrochipNumber { get; set; }
        public int BirthYear { get; set; }
        public string Color { get; set; }

        public int GenusId { get; set; }
        public Genus Genus { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Hospitalizasyon> Hospitalizasyons { get; set; }


    }
}
