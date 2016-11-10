using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Model.DomainModels;

namespace Project.Repository.Common
{
    public interface IVehicleModelRepository
    {
        Task<IVehicleModelDomainModel> Get(Guid id);
        Task<IEnumerable<IVehicleModelDomainModel>> GetAll();
        Task<int> Add(VehicleModelDomainModel entity);
        Task<int> Update(VehicleModelDomainModel entity);
        Task<int> Delete(Guid id);
        Task<ICollection<IVehicleModelDomainModel>> FetchModels(Guid id);
    }
}
