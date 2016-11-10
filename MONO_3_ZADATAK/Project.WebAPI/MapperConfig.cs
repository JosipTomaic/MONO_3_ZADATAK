using AutoMapper;
using Project.Model.Common;
using Project.Model.DomainModels;
using Project.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebAPI
{
    public class MapperConfig : Profile
    {
        protected override void Configure()
        {
            CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
        }
    }
}