using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PrivateCourseAttendance
    {
        public int id { set; get; }
        public DateTime date { set; get; }
        public PrivateTrainer privateTrainer { set; get; }
        public Member member { set; get; }
        public PrivateCourse privateCourse { set; get; }
     
    }
}
