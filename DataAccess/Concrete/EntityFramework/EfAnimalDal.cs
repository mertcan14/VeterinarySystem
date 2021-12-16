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
    public class EfAnimalDal:EfEntityRepositoryBase<Animal, VetContext>, IAnimalDal
    {
        public List<AnimalDetailDto> GetAllAnimalDetail(Expression<Func<AnimalDetailDto, bool>> filter = null) 
        {
            using (VetContext context = new VetContext())
            {
                var result = from an in context.animals
                             join gr in context.grades
                             on an.GradeId equals gr.Id
                             orderby gr.Name ascending
                             select new AnimalDetailDto
                             {
                                 Id = an.Id,
                                 Name = an.Name,
                                 GradeId = gr.Id,
                                 GradeName = gr.Name
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
