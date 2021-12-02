using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Accouting:IEntity
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
