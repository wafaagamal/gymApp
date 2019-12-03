using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
   public class PrivateCourseSubscriptions
    {
        public int id { set; get; }
        public DateTime startDate { set; get; }
        public DateTime endDate { set; get; }
        public int discount { set; get; }
        public virtual Member member { get; set; }
        public virtual PrivateCourse privateCourse { get; set; }
    }
}
