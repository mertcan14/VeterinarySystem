using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AddressDetailDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressTitle { get; set; }
        public string Definition { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int UserId { get; set; }
    }
}
