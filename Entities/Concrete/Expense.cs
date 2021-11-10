using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Expense:IEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
    }
}
