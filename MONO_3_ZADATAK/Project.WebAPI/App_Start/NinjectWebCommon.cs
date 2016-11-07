[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Project.WebAPI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Project.WebAPI.App_Start.NinjectWebCommon), "Stop")]

namespace Project.WebAPI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using System.Linq;
    using System.Web.Http;
    using DAL.Common;
    using DAL;
    using Repository.Common;
    using Repository;
    using Model.Common;
    using Model.ViewModels;
    using Model;
    using Model.DomainModels;
    using Service;
    using Service.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            //var settings = new NinjectSettings();
            //settings.LoadExtensions = true;
            //settings.ExtensionSearchPatterns = settings.ExtensionSearchPatterns.Union(new string[] { "Project.*.dll" }).ToArray();
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                GlobalConfiguration.Configuration.DependencyResolver = new Ninject.Web.WebApi.NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IVehicleContext>().To<VehicleContext>();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IRepository>().To<Repository>();
            kernel.Bind<IVehicleModelRepository>().To<VehicleModelRepository>();
            kernel.Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            kernel.Bind<IVehicleMakeViewModel>().To<VehicleMakeViewModel>();
            kernel.Bind<IVehicleModelViewModel>().To<VehicleModelViewModel>();
            kernel.Bind<IVehicleMakeDomainModel>().To<VehicleMakeDomainModel>();
            kernel.Bind<IVehicleModelDomainModel>().To<VehicleModelDomainModel>();
            kernel.Bind<IVehicleMake>().To<VehicleMake>();
            kernel.Bind<IVehicleModel>().To<VehicleModel>();
            kernel.Bind<IVehicleMakeService>().To<VehicleMakeService>();
            kernel.Bind<IVehicleModelService>().To<VehicleModelService>();
        }        
    }
}
