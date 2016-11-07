using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Project.Service.Common;
using Project.Repository.Common;
using Project.Repository;
using Project.Model.Common;
using Project.Model.ViewModels;
using Project.Model.DomainModels;
using Project.Model;

namespace Project.Service
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IVehicleMakeService>().To<VehicleMakeService>();
            Bind<IVehicleModelService>().To<VehicleModelService>();
        }
    }
}
