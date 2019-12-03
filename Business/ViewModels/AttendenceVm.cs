using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels
{
   public  class AttendenceVm
    {
        public int id { set; get; }
        public int memberId { set; get; }
        public DateTime time { set; get; }
        public int invitations { set; get; }
        //public Member member { set; get; }
    }
}
