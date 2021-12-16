using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class TransactionsDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
        public int Price { get; set; }
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int GenusId { get; set; }
        public string GenusName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<UsedProductDetailDto> UsedProducts { get; set; }
    }
}
