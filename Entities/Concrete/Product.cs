using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int StockQuantity { get; set; }

        public Category Category { get; set; }
        public Transactions Transactions { get; set; }
    }
}
