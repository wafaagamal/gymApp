using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels
{
    public class MemberVm
    {
        public string name{ set; get;}
        public int id { set; get; }
        public int invitations { set; get; }
        public int sessions { set; get; }
        public int memberShipId { set; get; }
        public int courseId { set; get; }
        public bool deleted { set; get; }
    }
}
