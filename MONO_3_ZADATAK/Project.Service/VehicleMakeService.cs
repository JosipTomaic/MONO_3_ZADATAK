using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Repository.Common;
using Project.Service.Common;
using Project.Model.DomainModels;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        private readonly IVehicleMakeRepository VehicleMakeRepo;
        private readonly IVehicleModelRepository VehicleModelRepo;

        public VehicleMakeService(IVehicleMakeRepository vehicleMakeRepo, IVehicleModelRepository vehicleModelRepo)
        {
            VehicleMakeRepo = vehicleMakeRepo;
            VehicleModelRepo = vehicleModelRepo;
        }

        public async Task<int> Add(VehicleMakeDomainModel entity)
        {
            return await VehicleMakeRepo.Add(entity);
        }

        public async Task<int> Delete(Guid id)
        {
            return await VehicleMakeRepo.Delete(id);
        }

        public async Task<IVehicleMakeDomainModel> Get(Guid id)
        {
            //return await VehicleMakeRepo.Get(id);
            var Response = await VehicleMakeRepo.Get(id);
            var ModelsForMaker = await VehicleModelRepo.FetchModels(id);
            Response.VehicleModels = ModelsForMaker;
            return Response;
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAll()
        {
            return await VehicleMakeRepo.GetAll();
        }

        public async Task<int> Update(VehicleMakeDomainModel entity)
        {
            return await VehicleMakeRepo.Update(entity);
        }
    }
}
