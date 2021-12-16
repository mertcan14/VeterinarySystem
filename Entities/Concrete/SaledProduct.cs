using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SaledProduct : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime AddedDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
    }
}
