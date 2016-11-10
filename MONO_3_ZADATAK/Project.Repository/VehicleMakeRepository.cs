using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Repository.Common;
using Project.Model;
using AutoMapper;
using Project.Model.DomainModels;
using Project.DAL.DatabaseModels;

namespace Project.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private readonly IRepository Repository;

        public VehicleMakeRepository(IRepository repository)
        {
            Repository = repository;
        }
        public async Task<int> Add(VehicleMakeDomainModel entity)
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

        public async Task<int> Update(VehicleMakeDomainModel entity)
        {
            return await Repository.Update(Mapper.Map<VehicleMake>(entity));
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAll()
        {
            return Mapper.Map<IEnumerable<IVehicleMakeDomainModel>>(await Repository.GetAll<VehicleMake>());
        }
    }
}
