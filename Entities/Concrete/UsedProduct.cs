using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UsedProduct : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime AddedDate { get; set; }

        public Product Product { get; set; }
        public Transactions Transactions { get; set; }
    }
}
