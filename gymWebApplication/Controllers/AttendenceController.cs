using Business.Repostories;
using Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace gymWebApplication.Controllers
{
    [RoutePrefix("api/member")]
    public class AttendenceController : ApiController
    {
        AttendenceRepo attendenceRepo = new AttendenceRepo();

        [Authorize(Roles = "receptionist")]
        public void Post([FromBody]AttendenceVm attVm)
        {
            attendenceRepo.Create(attVm);
        }

        [Route("{id}/attendance/{invitations}", Name = "Member Attendance")]
        [HttpGet]
        public void MemberAttendance(int id, int invitations)
        {
            AttendenceVm vm = new AttendenceVm()
            {
                memberId = id,
                invitations = invitations
            };
            attendenceRepo.Create(vm);
        }

       
      
    }
}
