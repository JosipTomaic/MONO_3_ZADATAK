using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;
using Project.Model;
using AutoMapper;
using Project.Model.DomainModels;
using System.Data.Entity;
using Project.DAL.DatabaseModels;

namespace Project.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private readonly IRepository Repository;

        public VehicleModelRepository(IRepository repository)
        {
            Repository = repository;
        }
        public async Task<int> Add(VehicleModelDomainModel entity)
        {
            return await Repository.Add(Mapper.Map<VehicleModel>(entity));
        }

        public async Task<int> Delete(Guid id)
        {
            return await Repository.Delete<VehicleModel>(id);
        }

        public async Task<int> Update(VehicleModelDomainModel entity)
        {
            return await Repository.Update(Mapper.Map<VehicleModel>(entity));
        }

        public async Task<IVehicleModelDomainModel> Get(Guid id)
        {
            return Mapper.Map<IVehicleModelDomainModel>(await Repository.Get<VehicleModel>(id));
        }

        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAll()
        {
            return Mapper.Map<IEnumerable<IVehicleModelDomainModel>>(await Repository.GetWhere<VehicleModel>().Include(i => i.VehicleMake).ToListAsync());
        }

        public async Task<ICollection<IVehicleModelDomainModel>> FetchModels(Guid id)
        {
            return Mapper.Map<ICollection<IVehicleModelDomainModel>>(await Repository.GetWhere<VehicleModel>().Where(i => i.VehicleMakeId == id).ToListAsync());
        }
    }
}
