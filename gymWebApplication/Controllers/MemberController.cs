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
    [Authorize (Roles="receptionist")]
    public class MemberController : ApiController
    {
        MemberRepo memberRepo = new MemberRepo();
        // GET api/values/5
        public MemberVm Get(int id)
        {
            return memberRepo.GetMember(id);
        }

        // POST api/values
        public void Post([FromBody]MemberVm memberVm)
        {
            memberRepo.CreateMember(memberVm);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            memberRepo.updateName(value, id);
        }

        // DELETE api/values/5s
        public void Delete(int id)
        {
            memberRepo.deleteByid(id);
        }

    }
}
