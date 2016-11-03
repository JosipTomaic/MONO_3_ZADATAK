using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Model
{
    public class VehicleModel : IVehicleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VehicleModelId { get; set; }
        public Guid VehicleMakeId { get; set; }
        public string Model { get; set; }
        public string Abrv { get; set; }

        public virtual VehicleMake VehicleMake { get; set; }
    }
}
