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
    public class MemberShipController : ApiController
    {

        MemberShipRepo memberShipRepo = new MemberShipRepo();
        public MemberShipVm Get(int id)
        {
            return memberShipRepo.GetMemberShip(id);
        }

        public void Post([FromBody] MemberShipVm memberShipVm)
        {
            memberShipRepo.Create(memberShipVm);
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]float value)
        {
            memberShipRepo.updatePrice(value, id);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            memberShipRepo.deleteById(id);
        }
    }
}
