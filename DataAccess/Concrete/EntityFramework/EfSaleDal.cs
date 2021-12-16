using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSaleDal : EfEntityRepositoryBase<Sale, VetContext>, ISaleDal
    {
        public List<SaleDetailDto> getAllDetail(Expression<Func<SaleDetailDto, bool>> filter = null)
        {
            using (VetContext context = new VetContext())
            {
                var result = from sa in context.sales
                             join pet in context.pets
                             on sa.PetId equals pet.Id
                             join cu in context.customers
                             on pet.CustomerId equals cu.Id
                             join ge in context.genus
                             on pet.GenusId equals ge.Id
                             select new SaleDetailDto
                             {
                                 Id = sa.Id,
                                 CustomerId = cu.Id,
                                 AddedDate = sa.AddedDate,
                                 CustomerName = cu.FirstName + " " + cu.LastName,
                                 GenusId = ge.Id,
                                 GenusName = ge.Name,
                                 PetId = pet.Id,
                                 PetName = pet.Name,
                                 Price = sa.Price,
                                 SaledProductDetails = (from sld in context.saledProducts join pr in context.products on sld.ProductId equals pr.Id where sld.SaleId == sa.Id select new SaledProductDetailDto { Id = sld.Id, Number = sld.Number, ProductName = pr.Name }).ToList()
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
