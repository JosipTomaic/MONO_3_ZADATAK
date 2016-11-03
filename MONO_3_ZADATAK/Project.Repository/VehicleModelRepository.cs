using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;
using Project.Model;
using AutoMapper;

namespace Project.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private IRepository Repository { get; set; }

        public VehicleModelRepository(IRepository repository)
        {
            Repository = repository;
        }
        public async Task<int> Add(IVehicleModelDomainModel entity)
        {
            return await Repository.Add(Mapper.Map<VehicleModel>(entity));
        }

        public async Task<int> Delete(Guid id)
        {
            return await Repository.Delete<VehicleModel>(id);
        }

        public async Task<int> Update(IVehicleModelDomainModel entity)
        {
            return await Repository.Update(Mapper.Map<VehicleModel>(entity));
        }

        public async Task<IVehicleModelDomainModel> Get(Guid id)
        {
            return Mapper.Map<IVehicleModelDomainModel>(await Repository.Get<VehicleModel>(id));
        }

        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAll()
        {
            return Mapper.Map<IVehicleModelDomainModel>(await Repository.GetAll());
        }
    }
}
