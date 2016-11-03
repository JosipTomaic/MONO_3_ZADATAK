using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Repository.Common;
using Project.Model;
using AutoMapper;

namespace Project.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private IRepository Repository { get; set; }

        public VehicleMakeRepository(IRepository repository)
        {
            Repository = repository;
        }
        public async Task<int> Add(IVehicleMakeDomainModel entity)
        {
            return await Repository.Add(Mapper.Map<VehicleMake>(entity));
        }

        public async Task<int> Delete(Guid id)
        {
            return await Repository.Delete<VehicleMake>(id);
        }

        public async Task<IVehicleMakeDomainModel> Get(Guid id)
        {
            return Mapper.Map<IVehicleMakeDomainModel>(await Repository.Get<VehicleMake>(id));
        }

        public async Task<int> Update(IVehicleMakeDomainModel entity)
        {
            return await Repository.Update(Mapper.Map<VehicleMake>(entity));
        }
    }
}
