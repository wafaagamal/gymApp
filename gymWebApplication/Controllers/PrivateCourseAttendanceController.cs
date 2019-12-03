using Business.Repostories;
using Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace gymWebApplication.Controllers
{
    [Authorize(Roles = "receptionist")]
    public class PrivateCourseAttendanceController : ApiController
    {
        PrivateCourseAttendanceRepo attendenceRepo = new PrivateCourseAttendanceRepo();
        public async Task Post([FromBody]PrivateCourseAttendanceVm attVm)
        {
            await attendenceRepo.Create(attVm);
        }
    }
}
