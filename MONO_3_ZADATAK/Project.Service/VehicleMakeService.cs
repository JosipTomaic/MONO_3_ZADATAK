using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Repository.Common;
using Project.Service.Common;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        private readonly IVehicleMakeRepository VehicleMakeRepo;

        public VehicleMakeService(IVehicleMakeRepository vehiclemakerepo)
        {
            VehicleMakeRepo = vehiclemakerepo;
        }

        public async Task<int> Add(IVehicleMakeDomainModel entity)
        {
            return await VehicleMakeRepo.Add(entity);
        }

        public async Task<int> Delete(Guid id)
        {
            return await VehicleMakeRepo.Delete(id);
        }

        public async Task<IVehicleMakeDomainModel> Get(Guid id)
        {
            return await VehicleMakeRepo.Get(id);
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAll()
        {
            return await VehicleMakeRepo.GetAll();
        }

        public async Task<int> Update(IVehicleMakeDomainModel entity)
        {
            return await VehicleMakeRepo.Update(entity);
        }
    }
}
