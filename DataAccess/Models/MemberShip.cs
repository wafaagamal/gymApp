using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DataAccess.Models
{
    public class MemberShip
    {
     
        public int id { set; get; }
        public int duration { set; get; }
        public string name { set; get; }
        public int invitations { set; get; }
        public float price { set; get; }
        [DefaultValue("false")]
        public bool deleted { set; get; }
        public virtual List<MemberSubscribtion> MemberSubscribtions { set; get; }
    }
}
