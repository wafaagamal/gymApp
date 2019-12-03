using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Models
{
    public class MemberSubscribtion
    {
        public int id { set; get; }
        public float discount { set; get; }
        public DateTime startTime { set; get; }
        public DateTime endTime { set; get; }
        public bool paid { set; get; }
        public  virtual Member Member { get; set; }
        public virtual MemberShip MemberShip { get; set; }
    }
}
