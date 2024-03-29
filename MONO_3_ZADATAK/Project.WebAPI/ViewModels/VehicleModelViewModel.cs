﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.WebAPI.ViewModels
{
    public class VehicleModelViewModel
    {
        public Guid VehicleModelId { get; set; }
        public Guid VehicleMakeId { get; set; }
        public string Model { get; set; }
        public string Abrv { get; set; }

        public virtual VehicleMakeViewModel VehicleMake { get; set; }
    }
}