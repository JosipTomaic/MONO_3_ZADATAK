using Ninject.Modules;
using Project.DAL;
using Project.DAL.Common;
using Project.DAL.DatabaseModels;
using Project.Model.Common;
using Project.Model.DomainModels;
using Project.Repository;
using Project.Repository.Common;
using Project.Service;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DI
{
    public class NinjectBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IVehicleContext>().To<VehicleContext>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IRepository>().To<Repository.Repository>();
            Bind<IVehicleModelRepository>().To<VehicleModelRepository>();
            Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleMakeDomainModel>().To<VehicleMakeDomainModel>();
            Bind<IVehicleModelDomainModel>().To<VehicleModelDomainModel>();
            Bind<IVehicleMake>().To<VehicleMake>();
            Bind<IVehicleModel>().To<VehicleModel>();
            Bind<IVehicleMakeService>().To<VehicleMakeService>();
            Bind<IVehicleModelService>().To<VehicleModelService>();
        }
    }
}
