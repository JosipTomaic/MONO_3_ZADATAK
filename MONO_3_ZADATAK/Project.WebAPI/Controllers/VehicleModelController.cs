using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Project.Model.Common;
using System.Web.Http;
using System.Net;
using Project.Model.ViewModels;

namespace Project.WebAPI.Controllers
{
    public class VehicleModelController : ApiController
    {
        private IVehicleModelService VModelService;

        public VehicleModelController(IVehicleModelService vmodelservice)
        {
            VModelService = vmodelservice;
        }

        public async Task<HttpResponseMessage> FetchVehicleModels()
        {
            var VehicleModelList = Mapper.Map<IEnumerable<IVehicleModelViewModel>>(await VModelService.GetAll());
            return Request.CreateResponse(HttpStatusCode.OK, VehicleModelList);
        }

        public async Task<HttpResponseMessage> AddVehicleModel(VehicleModelViewModel vmodelviewmodel)
        {
            if(String.IsNullOrEmpty(vmodelviewmodel.Model) || String.IsNullOrEmpty(vmodelviewmodel.Abrv))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "You must input all required data.");
            }

            vmodelviewmodel.VehicleMakeId = Guid.NewGuid();

            var Response = await VModelService.Add(Mapper.Map<IVehicleModelDomainModel>(vmodelviewmodel));

            return Request.CreateResponse(HttpStatusCode.OK, Response);
        }

        public async Task<HttpResponseMessage> EditVehicleModel(VehicleModelViewModel vmodelviewmodel)
        {
            var Finder = await VModelService.Get(vmodelviewmodel.VehicleModelId);
            if(String.IsNullOrEmpty(Finder.Model) || String.IsNullOrEmpty(Finder.Abrv))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Your input is incorrect.");
            }
            else
            {
                Finder.Model = vmodelviewmodel.Model;
                Finder.Abrv = vmodelviewmodel.Abrv;
            }
            var Response = await VModelService.Update(Mapper.Map<IVehicleModelDomainModel>(Finder));
            return Request.CreateResponse(HttpStatusCode.OK, Response);
        }

        public async Task<HttpResponseMessage> DeleteVehicleModel(Guid id)
        {
            var Destroyer = await VModelService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, Destroyer);
        }
    }
}