using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal:EfEntityRepositoryBase<Address, VetContext>, IAddressDal
    {
        public List<AddressDetailDto> GetAllDetail(Expression<Func<AddressDetailDto, bool>> filter = null)
        {
            using (VetContext context = new VetContext())
            {
                var result = from ad in context.addresses
                             join di in context.districts
                             on ad.DistrictId equals di.Id
                             join ci in context.cities
                             on di.CityId equals ci.Id
                             select new AddressDetailDto
                             {
                                 AddressTitle = ad.AddressTitle,
                                 Id = ad.Id,
                                 CityId = ci.Id,
                                 CityName = ci.Name,
                                 Definition = ad.Definition,
                                 DistrictId = di.Id,
                                 DistrictName = di.Name,
                                 FirstName = ad.FirstName,
                                 LastName = ad.LastName,
                                 UserId = ad.UserId
                             };

                if (filter is null)
                {
                    return result.ToList();
                }
                else
                {
                    return result.Where(filter).ToList();
                }
            }
        }
    }
}
