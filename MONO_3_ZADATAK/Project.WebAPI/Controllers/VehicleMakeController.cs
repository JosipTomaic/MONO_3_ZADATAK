using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using System.Net;
using Project.Model.DomainModels;
using Project.WebAPI.ViewModels;

namespace Project.WebAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/vehiclemake")]
    public class VehicleMakeController : ApiController
    {
        private readonly IVehicleMakeService VMakeService;

        public VehicleMakeController(IVehicleMakeService vmakeservice)
        {
            VMakeService = vmakeservice;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetAllVMake")]
        public async Task<HttpResponseMessage> FetchVehicleMakers()
        {
            var VehicleMakeList = Mapper.Map<IEnumerable<VehicleMakeViewModel>>(await VMakeService.GetAll());
            return Request.CreateResponse(HttpStatusCode.OK, VehicleMakeList);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetVMake")]
        public async Task<HttpResponseMessage> GetVehicleMaker(Guid id)
        {
            var Response = Mapper.Map<VehicleMakeViewModel>(await VMakeService.Get(id));
            return Request.CreateResponse(HttpStatusCode.OK, Response);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("AddVMake")]
        public async Task<HttpResponseMessage> AddVehicleMaker(VehicleMakeViewModel vmakeviewmodel)
        {
            if(String.IsNullOrEmpty(vmakeviewmodel.Name) || String.IsNullOrEmpty(vmakeviewmodel.Abrv))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "You must input all required data.");
            }

            vmakeviewmodel.VehicleMakeId = Guid.NewGuid();
            var Response = await VMakeService.Add(Mapper.Map<VehicleMakeDomainModel>(vmakeviewmodel));
            return Request.CreateResponse(HttpStatusCode.OK, Response);
        }

        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("EditVMake")]
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

            var Response = await VMakeService.Update(Mapper.Map<VehicleMakeDomainModel>(Finder));
            return Request.CreateResponse(HttpStatusCode.OK, Response);
        }

        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("DeleteVMake")]
        public async Task<HttpResponseMessage> DeleteVehicleMaker(Guid id)
        {
            var Destroyer = await VMakeService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, Destroyer);
        }
    }
}