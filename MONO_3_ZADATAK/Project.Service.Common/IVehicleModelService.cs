using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IVehicleModelService
    {
        Task<IVehicleModelDomainModel> Get(Guid id);
        Task<int> Add(IVehicleModelDomainModel entity);
        Task<int> Update(IVehicleModelDomainModel entity);
        Task<int> Delete(Guid id);
    }
}
