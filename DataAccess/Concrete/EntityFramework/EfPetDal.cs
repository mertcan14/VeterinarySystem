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
    public class EfPetDal : EfEntityRepositoryBase<Pet, VetContext>, IPetDal
    {
        public PetDetailDto GetPetDetail(int id)
        {
            using (VetContext context = new VetContext())
            {
                var result = from pe in context.pets
                             join ge in context.genus
                             on pe.GenusId equals ge.Id
                             join cu in context.customers
                             on pe.CustomerId equals cu.Id
                             join gen in context.genders
                             on pe.GenderId equals gen.Id
                             where pe.Id == id
                             select new PetDetailDto
                             {
                                 BirthYear = pe.BirthYear,
                                 Color = pe.Color,
                                 CustomerName = cu.FirstName + " " + cu.LastName,
                                 GenderName = gen.Name,
                                 Name = pe.Name,
                                 GenusName = ge.Name,
                                 MicrochipNumber = pe.MicrochipNumber,
                                 Id = pe.Id
                             };
                return result.First();
            }
        }
        public List<PetDetailDto> GetAllPetDetail(Expression<Func<PetDetailDto, bool>> filter = null)
        {
            using (VetContext context = new VetContext())
            {
                var result = from pe in context.pets
                             join ge in context.genus
                             on pe.GenusId equals ge.Id
                             join cu in context.customers
                             on pe.CustomerId equals cu.Id
                             join gen in context.genders
                             on pe.GenderId equals gen.Id
                             select new PetDetailDto
                             {
                                 BirthYear = pe.BirthYear,
                                 Color = pe.Color,
                                 CustomerName = cu.FirstName + " " + cu.LastName,
                                 GenderName = gen.Name,
                                 Name = pe.Name,
                                 GenusName = ge.Name,
                                 MicrochipNumber = pe.MicrochipNumber,
                                 Id = pe.Id
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
