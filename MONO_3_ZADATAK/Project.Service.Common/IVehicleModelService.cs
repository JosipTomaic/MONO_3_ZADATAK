using Project.Model.Common;
using Project.Model.DomainModels;
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
        Task<IEnumerable<IVehicleModelDomainModel>> GetAll();
        Task<int> Add(VehicleModelDomainModel entity);
        Task<int> Update(VehicleModelDomainModel entity);
        Task<int> Delete(Guid id);
    }
}
