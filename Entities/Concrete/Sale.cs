using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sale : IEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public int Price { get; set; }

        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public List<SaledProduct> SaledProducts { get; set; }
    }
}
