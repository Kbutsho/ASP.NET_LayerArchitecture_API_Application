using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BusinessLogicLayer.Entities;
using BusinessLogicLayer.Services;

namespace PresentationLayer.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(UserModel user)
        {
            var token = AuthService.Authenticate(user);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);

            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }
        [Route("api/logout")]
        [HttpPost]
        public void Logout(TokenModel e)
        {
            AuthService.Logout(e);
        }
    }
}
