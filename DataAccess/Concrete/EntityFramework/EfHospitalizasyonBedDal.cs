using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHospitalizasyonBedDal:EfEntityRepositoryBase<HospitalizasyonBed, VetContext>, IHospitalizasyonBedDal
    {
    }
}
