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
    public class EfGenusDal:EfEntityRepositoryBase<Genus, VetContext>, IGenusDal
    {
        public List<GenusDetailDto> GetAllGenusDetail(Expression<Func<GenusDetailDto, bool>> filter = null)
        {
            using (VetContext context = new VetContext())
            {
                var result = from ge in context.genus
                             join an in context.animals
                             on ge.AnimalId equals an.Id
                             orderby an.Name ascending
                             select new GenusDetailDto
                             {
                                 Name = ge.Name,
                                 Id = ge.Id,
                                 AnimalId = an.Id,
                                 AnimalName = an.Name
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
