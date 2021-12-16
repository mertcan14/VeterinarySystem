using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UsedProductDetailDto
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public string ProductName { get; set; }
        public string TransactionsName { get; set; }
    }
}
