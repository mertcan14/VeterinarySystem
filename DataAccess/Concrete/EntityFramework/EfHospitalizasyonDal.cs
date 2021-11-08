using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHospitalizasyonDal:EfEntityRepositoryBase<Hospitalizasyon, VetContext>, IHospitalizasyonDal
    {
        public List<HospitalizasyonBed> BedAvailable(DateTime entryDate, DateTime releaseDate, int bedCategoryId)
        {
            using (VetContext context = new VetContext())
            {
                var result1 = from hb in context.hospitalizasyonBeds
                             where hb.HospitalCategory.Id == bedCategoryId
                             select hb;

                var result2 = from h in context.hospitalizasyons
                              where h.HospitalizasyonBed.HospitalCategory.Id == bedCategoryId && (h.EntryDate.Date <= releaseDate && h.ReleaseDate >= entryDate)
                              select h.HospitalizasyonBed;

                var sonuc = result1.Where(p => !result2.Select(i => i.Id).Contains(p.Id));
                return sonuc.ToList();
            }
        }
    }
}
