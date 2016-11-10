using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Model.DomainModels;

namespace Project.Repository.Common
{
    public interface IVehicleMakeRepository
    {
        Task<IVehicleMakeDomainModel> Get(Guid id);
        Task<IEnumerable<IVehicleMakeDomainModel>> GetAll();
        Task<int> Add(VehicleMakeDomainModel entity);
        Task<int> Update(VehicleMakeDomainModel entity);
        Task<int> Delete(Guid id);
    }
}
