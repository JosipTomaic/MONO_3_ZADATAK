using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.WebAPI.ViewModels
{
    public class VehicleMakeViewModel
    {
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual ICollection<VehicleModelViewModel> VehicleModels { get; set; }
    }
}
