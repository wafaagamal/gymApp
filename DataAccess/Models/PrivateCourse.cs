using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
   public class PrivateCourse
    {
        public int id { set; get; }
        public string name { set; get; }
        public float price { set; get; }
        public int duration { set; get; }
        public int sessions { set; get; }
        [DefaultValue("false")]
        public bool deleted { set; get; }
        public virtual List<PrivateCourseSubscriptions> courseSubscriptions { set; get; }
    }
}
