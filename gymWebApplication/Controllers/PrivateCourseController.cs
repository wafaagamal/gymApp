using Business.Repostories;
using Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gymWebApplication.Controllers
{
    [Authorize(Roles = "admin")]
    public class PrivateCourseController : ApiController
    {
        PrivateCourseRepo CourseRepo = new PrivateCourseRepo();
        // GET api/values/5
        public PrivateCourseVm Get([FromBody]PrivateCourseVm CourseVm)
        {
            return CourseRepo.GetCourse(CourseVm);
        }

        // POST api/values
        public void Post([FromBody]PrivateCourseVm CourseVm)
        {
            CourseRepo.createCourse(CourseVm);
        }

        // PUT api/values/5
        public void Put([FromBody]PrivateCourseVm CourseVm)
        {
            CourseRepo.updatePrice(CourseVm);
        }

        // DELETE api/values/5
        public void Delete([FromBody]PrivateCourseVm CourseVm)
        {
            CourseRepo.deleteById(CourseVm);
        }

    }
}
