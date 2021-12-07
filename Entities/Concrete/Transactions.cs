using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Transactions : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
        public int Price { get; set; }

        public Pet Pet { get; set; }
        public List<UsedProduct> UsedProducts { get; set; }
    }
}
