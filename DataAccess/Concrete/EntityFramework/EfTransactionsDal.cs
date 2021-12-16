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
    public class EfTransactionsDal : EfEntityRepositoryBase<Transactions, VetContext>, ITransactionsDal
    {
        public List<TransactionsDetailDto> getAllDetail(Expression<Func<TransactionsDetailDto, bool>> filter = null)
        {
            using (VetContext context = new VetContext())
            {
                var result = from tr in context.Transactions
                             join pet in context.pets
                             on tr.PetId equals pet.Id
                             join cu in context.customers
                             on pet.CustomerId equals cu.Id
                             join ge in context.genus
                             on pet.GenusId equals ge.Id
                             select new TransactionsDetailDto
                             {
                                 Id = tr.Id,
                                 GenusId = ge.Id,
                                 AddedDate = tr.AddedDate,
                                 CustomerId = cu.Id,
                                 CustomerName = cu.FirstName + cu.LastName,
                                 GenusName = ge.Name,
                                 Name = tr.Name,
                                 PetId = pet.Id,
                                 PetName = pet.Name,
                                 Price = tr.Price,
                                 UsedProducts = (from uspp in context.usedProducts join pro in context.products on uspp.ProductId equals pro.Id where uspp.TransactionsId == tr.Id select new UsedProductDetailDto {Id = uspp.Id, Number=uspp.Number, ProductName=pro.Name, TransactionsName=tr.Name }).ToList()
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
