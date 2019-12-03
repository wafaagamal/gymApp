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
    public class PrivateTrainerController : ApiController
    {
        PrivateTrainerRepo trainerRepo = new PrivateTrainerRepo();
        // GET api/values/5

        public PrivateTrainerVm Get([FromBody]PrivateTrainerVm trainerVm)
        {
            return trainerRepo.GetTrainer(trainerVm);
        }

        // POST api/values
        public void Post([FromBody]PrivateTrainerVm trainerVm)
        {
            trainerRepo.createTrainer(trainerVm);
        }

        // PUT api/values/5
        public void Put([FromBody]PrivateTrainerVm trainerVm)
        {
            trainerRepo.updateName(trainerVm);
        }

        // DELETE api/values/5
        public void Delete([FromBody]PrivateTrainerVm trainerVm)
        {
            trainerRepo.deleteById(trainerVm);
        }

    }
}
