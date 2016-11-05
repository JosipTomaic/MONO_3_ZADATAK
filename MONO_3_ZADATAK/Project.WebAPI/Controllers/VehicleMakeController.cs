using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Project.Model.Common;
using System.Net;
using Project.Model.ViewModels;

namespace Project.WebAPI.Controllers
{
    public class VehicleMakeController : ApiController
    {
        private IVehicleMakeService VMakeService;

        public VehicleMakeController(IVehicleMakeService vmakeservice)
        {
            VMakeService = vmakeservice;
        }

        public async Task<HttpResponseMessage> FetchVehicleMakers()
        {
            var VehicleMakeList = Mapper.Map<IEnumerable<IVehicleMakeViewModel>>(await VMakeService.GetAll());
            return Request.CreateResponse(HttpStatusCode.OK, VehicleMakeList);
        }

        public async Task<HttpResponseMessage> AddVehicleMaker(VehicleMakeViewModel vmakeviewmodel)
        {
            if(String.IsNullOrEmpty(vmakeviewmodel.Name) || String.IsNullOrEmpty(vmakeviewmodel.Abrv))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "You must input all required data.");
            }

            vmakeviewmodel.VehicleMakeId = Guid.NewGuid();
            var Response = await VMakeService.Add(Mapper.Map<IVehicleMakeDomainModel>(vmakeviewmodel));
            return Request.CreateResponse(HttpStatusCode.OK, Response);
        }

        public async Task<HttpResponseMessage> EditVehicleMaker(VehicleMakeViewModel vmakeviewmodel)
        {
            var Finder = await VMakeService.Get(vmakeviewmodel.VehicleMakeId);
            if(String.IsNullOrEmpty(Finder.Name) || String.IsNullOrEmpty(Finder.Abrv))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Your input is incorrect");
            }
            else
            {
                Finder.Name = vmakeviewmodel.Name;
                Finder.Abrv = vmakeviewmodel.Abrv;
            }

            var Response = await VMakeService.Update(Mapper.Map<IVehicleMakeDomainModel>(Finder));
            return Request.CreateResponse(HttpStatusCode.OK, Response);
        }

        public async Task<HttpResponseMessage> DeleteVehicleMaker(Guid id)
        {
            var Destroyer = await VMakeService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, Destroyer);
        }
    }
}