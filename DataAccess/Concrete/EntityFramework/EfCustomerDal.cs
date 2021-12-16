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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, VetContext>, ICustomerDal
    {
        public List<CustomerDetailDto> getAllCustomerDetailDto(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using (VetContext context = new VetContext())
            {
                var result = from cu in context.customers
                             join us in context.users
                             on cu.UserId equals us.Id
                             select new CustomerDetailDto
                             {
                                 Email = us.Email,
                                 Id = cu.Id,
                                 UserId = cu.UserId,
                                 FirstName = cu.FirstName,
                                 LastName = cu.LastName,
                                 PhoneNumber = cu.PhoneNumber
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

        public CustomerDetailDto getCustomerDetailDtoById(int id)
        {
            using (VetContext context = new VetContext())
            {
                var result = from cu in context.customers
                             join us in context.users
                             on cu.UserId equals us.Id
                             where cu.Id == id
                             select new CustomerDetailDto
                             {
                                 Email = us.Email,
                                 Id = cu.Id,
                                 UserId = cu.UserId,
                                 FirstName = cu.FirstName,
                                 LastName = cu.LastName,
                                 PhoneNumber = cu.PhoneNumber
                             };

                return result.First();
            }
        }
    }
}
