using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PrivateTrainer
    {
        public int id { set; get; }
        public string name { set; get; }
        [DefaultValue("false")]
        public bool deleted { set; get; }
        public virtual List<PrivateCourseAttendance> CourseAttendances { set; get; }
    }
}
