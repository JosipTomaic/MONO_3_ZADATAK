using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Model.ViewModels
{
    public class VehicleMakeViewModel : IVehicleMakeViewModel
    {
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public ICollection<VehicleModelViewModel> VehicleModels { get; set; }
    }
}
