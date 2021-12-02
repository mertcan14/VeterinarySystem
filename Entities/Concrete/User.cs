using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
