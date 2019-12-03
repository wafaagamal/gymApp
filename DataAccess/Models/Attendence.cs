using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DataAccess.Models
{
   public  class Attendence
    {
        public int id { set; get; }
        public DateTime time { set; get; }
        public int invitations { set; get; }
        public Member member { set; get; }

    }
}
