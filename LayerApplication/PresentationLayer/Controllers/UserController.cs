using BusinessLogicLayer.Entities;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/admin/all")]
        [HttpGet]
        public List<UserModel> Admin()
        {
            return UserService.AdminList();
        }
        [Route("api/seller/all")]
        [HttpGet]
        public List<UserModel> Seller()
        {
            return UserService.SellerList();
        }
        [Route("api/customer/all")]
        [HttpGet]
        public List<UserModel> Customer()
        {
            return UserService.CustomerList();
        }
        [Route("api/deliveryBoy/all")]
        [HttpGet]
        public List<UserModel> DeliveryBoy()
        {
            return UserService.DeliveryBoyList();
        }
        [HttpGet]
        [Route("api/user/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var st = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
    }
}
