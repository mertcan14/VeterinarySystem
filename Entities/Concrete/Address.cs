using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressTitle { get; set; }
        public string Definition { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
