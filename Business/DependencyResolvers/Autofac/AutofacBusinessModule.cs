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
        }
    }
}
