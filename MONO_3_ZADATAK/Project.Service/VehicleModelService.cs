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
    public class VehicleModelService : IVehicleModelService
    {
        private IVehicleModelRepository VehicleModelRepo;

        public VehicleModelService(IVehicleModelRepository vehiclemodelrepo)
        {
            VehicleModelRepo = vehiclemodelrepo;
        }

        public async Task<int> Add(IVehicleModelDomainModel entity)
        {
            return await VehicleModelRepo.Add(entity);
        }

        public async Task<int> Delete(Guid id)
        {
            return await VehicleModelRepo.Delete(id);
        }

        public async Task<IVehicleModelDomainModel> Get(Guid id)
        {
            return await VehicleModelRepo.Get(id);
        }

        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAll()
        {
            return await VehicleModelRepo.GetAll();
        }

        public async Task<int> Update(IVehicleModelDomainModel entity)
        {
            return await VehicleModelRepo.Update(entity);
        }
    }
}
