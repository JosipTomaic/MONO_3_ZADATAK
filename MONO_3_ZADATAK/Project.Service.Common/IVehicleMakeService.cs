using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IVehicleMakeService
    {
        Task<IVehicleMakeDomainModel> Get(Guid id);
        Task<IEnumerable<IVehicleMakeDomainModel>> GetAll();
        Task<int> Add(IVehicleMakeDomainModel entity);
        Task<int> Update(IVehicleMakeDomainModel entity);
        Task<int> Delete(Guid id);
    }
}
