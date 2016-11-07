using AutoMapper;
using Project.Model;
using Project.Model.Common;
using Project.Model.DomainModels;
using Project.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebAPI.App_Start
{
    static public class MapperConfig
    {
        public static void config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
                cfg.CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
                cfg.CreateMap<IVehicleMake, IVehicleMakeDomainModel>().ReverseMap();
                cfg.CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();
                cfg.CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
                cfg.CreateMap<VehicleMakeDomainModel, IVehicleMakeViewModel>().ReverseMap();
                cfg.CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
                cfg.CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
                cfg.CreateMap<IVehicleMakeDomainModel, IVehicleMakeViewModel>().ReverseMap();
                cfg.CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
                cfg.CreateMap<IVehicleModel, IVehicleModelDomainModel>().ReverseMap();
                cfg.CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
                cfg.CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();
                cfg.CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
                cfg.CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();
                cfg.CreateMap<IVehicleModelDomainModel, IVehicleModelViewModel>().ReverseMap();
                cfg.CreateMap<VehicleModelDomainModel, IVehicleModelViewModel>().ReverseMap();
                cfg.CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            });
        }
    }
}