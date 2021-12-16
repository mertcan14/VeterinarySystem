using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, VetContext>, IUserDal
    {
        public int AddReturnId(User user)
        {
            using (VetContext context = new VetContext())
            {
                var addedEntity = context.Entry(user);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return user.Id;
            }
        }
    }
}
