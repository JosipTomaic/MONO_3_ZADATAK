using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Repository.Common
{
    public interface IVehicleModelRepository
    {
        Task<IVehicleModelDomainModel> Get(Guid id);
        Task<IEnumerable<IVehicleModelDomainModel>> GetAll();
        Task<int> Add(IVehicleModelDomainModel entity);
        Task<int> Update(IVehicleModelDomainModel entity);
        Task<int> Delete(Guid id);
    }
}
