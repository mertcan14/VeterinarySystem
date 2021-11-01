using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class District:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public City City { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
