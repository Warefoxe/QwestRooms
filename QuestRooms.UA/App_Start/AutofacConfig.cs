using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using QuestRooms.BLL.DTOModels;
using QuestRooms.BLL.Mapping;
using QuestRooms.BLL.Servises.Abstraction;
using QuestRooms.BLL.Servises.Implementation;
using QuestRooms.DAL;
using QuestRooms.DAL.Entities;
using QuestRooms.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UA.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            RegisterTypes(builder);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));

        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<MapperProfile>());
            Mapper mapper = new Mapper(mapperConfig);
            builder.RegisterInstance(mapper).As<IMapper>();
            builder.RegisterType<RoomsContext>().As<DbContext>();
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<CitiesService>().As<ICitiesService>();
            
            //builder.RegisterType<RoomsContext>().As<DbContext>();
        }
    }
}