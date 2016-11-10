using AutoMapper;
using Project.DAL.Common;
using Project.DAL.DatabaseModels;
using Project.Model.Common;
using Project.Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.DI
{
    public class MapperConfig : Profile
    {
        protected override void Configure()
        {
           CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
           CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
           CreateMap<IVehicleMake, IVehicleMakeDomainModel>().ReverseMap();
           CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();
           CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
           CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
           CreateMap<IVehicleModel, IVehicleModelDomainModel>().ReverseMap();
           CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
           CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();
           CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();
        }
    }
}