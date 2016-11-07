using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Project.Repository.Common;
using Project.Repository;
using Project.Model.Common;
using Project.Model.ViewModels;
using Project.Model.DomainModels;
using Project.Model;
using Project.DAL.Common;
using Project.DAL;

namespace Project.Repository
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IVehicleContext>().To<VehicleContext>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IRepository>().To<Repository>();
            //Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleModelRepository>().To<VehicleModelRepository>();
            Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleMakeViewModel>().To<VehicleMakeViewModel>();
            Bind<IVehicleModelViewModel>().To<VehicleModelViewModel>();
            Bind<IVehicleMakeDomainModel>().To<VehicleMakeDomainModel>();
            Bind<IVehicleModelDomainModel>().To<VehicleModelDomainModel>();
            Bind<IVehicleMake>().To<VehicleMake>();
            Bind<IVehicleModel>().To<VehicleModel>();
        }
    }
}
