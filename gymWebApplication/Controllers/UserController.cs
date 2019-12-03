using Business.Repostories;
using Business.ViewModels;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace gymWebApplication.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult Get()
        {
            var identity = (ClaimsIdentity)User.Identity;

            return Ok("Hello: " + identity.Name);
        }
        //Register admin or receptionist
        [Authorize(Roles = "admin")]
        public void Post([FromBody]UserVm userVm)
        {
            if (userVm.username != null && userVm.email != null && userVm.password != null && userVm.role != null)
            {
                UserRepo userRepo = new UserRepo();
                userRepo.AddUser(userVm);
            }

        }
    
        //[Authorize(Roles = "admin")]
        [HttpGet]
        [Route("user")]
        public IHttpActionResult getUser([FromBody]UserVm userVm)
        {
            if ( userVm.email != null)
            {
                UserRepo userRepo = new UserRepo();
                return Ok(userRepo.FindUser(userVm));
            }
            return Content(HttpStatusCode.BadRequest, "user not found");
        }
        //[HttpPost]
        //[AllowAnonymous]
        //[Route("Account/Login")]
        //public void Login([FromBody]UserVm userVm)
        //{
        //    if (userVm.username != null && userVm.email != null && userVm.password != null )
        //    {
        //        UserRepo userRepo = new UserRepo();
        //        var result=userRepo.Login(userVm);
        //        if (result == SignInStatus.Success)
        //        {
        //            System.Diagnostics.Debug.WriteLine("Success to Login");
        //        }
        //        if (result== SignInStatus.Failure)
        //        {
        //            System.Diagnostics.Debug.WriteLine("Fail to Login");
        //        }

        //    }

        //}
    }
}
