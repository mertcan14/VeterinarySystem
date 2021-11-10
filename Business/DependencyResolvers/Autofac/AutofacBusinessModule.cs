using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().SingleInstance();

            builder.RegisterType<AddressManager>().As<IAddressService>().SingleInstance();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>().SingleInstance();

            builder.RegisterType<GradeManager>().As<IGradeService>().SingleInstance();
            builder.RegisterType<EfGradeDal>().As<IGradeDal>().SingleInstance();

            builder.RegisterType<AnimalManager>().As<IAnimalService>().SingleInstance();
            builder.RegisterType<EfAnimalDal>().As<IAnimalDal>().SingleInstance();

            builder.RegisterType<GenusManager>().As<IGenusService>().SingleInstance();
            builder.RegisterType<EfGenusDal>().As<IGenusDal>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<HospitalCategoryManager>().As<IHospitalCategoryService>().SingleInstance();
            builder.RegisterType<EfHospitalCategoryDal>().As<IHospitalCategoryDal>().SingleInstance();

            builder.RegisterType<HospitalizasyonBedManager>().As<IHospitalizasyonBedService>().SingleInstance();
            builder.RegisterType<EfHospitalizasyonBedDal>().As<IHospitalizasyonBedDal>().SingleInstance();

            builder.RegisterType<HospitalizasyonManager>().As<IHospitalizasyonService>().SingleInstance();
            builder.RegisterType<EfHospitalizasyonDal>().As<IHospitalizasyonDal>().SingleInstance();

            builder.RegisterType<ExpenseManager>().As<IExpenseService>().SingleInstance();
            builder.RegisterType<EfExpenseDal>().As<IExpenseDal>().SingleInstance();

            builder.RegisterType<AccoutingManager>().As<IAccoutingService>().SingleInstance();
            builder.RegisterType<EfAccoutingDal>().As<IAccoutingDal>().SingleInstance();

            builder.RegisterType<InComeManager>().As<IInComeService>().SingleInstance();
            builder.RegisterType<EfInComeDal>().As<IInComeDal>().SingleInstance();
        }
    }
}
