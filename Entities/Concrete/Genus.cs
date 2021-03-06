using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Genus:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AnimalId { get; set; }

        public Animal Animal { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
