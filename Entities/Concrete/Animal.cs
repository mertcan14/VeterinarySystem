using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Animal:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Grade Grade { get; set; }
        public List<Genus> Genus { get; set; }
    }
}
