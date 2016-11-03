using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Repository.Common
{
    public interface IVehicleMakeRepository
    {
        Task<IVehicleMakeDomainModel> Get(Guid id);
        Task<int> Add(IVehicleMakeDomainModel entity);
        Task<int> Update(IVehicleMakeDomainModel entity);
        Task<int> Delete(Guid id);
    }
}
