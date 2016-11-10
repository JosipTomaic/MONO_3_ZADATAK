using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Common;
using System.ComponentModel.DataAnnotations;

namespace Project.DAL.DatabaseModels
{
    public class VehicleMake : IVehicleMake
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
