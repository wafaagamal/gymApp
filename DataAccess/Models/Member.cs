using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DataAccess.Models
{
    public class Member
    {
        [Key]
        public int id { set; get; }
     
        public string name { set; get; }
        public int invitations { set; get; }
        [DefaultValue("false")]
        public bool deleted { set; get; }
        public int sessions { set; get; }
        public virtual List<MemberSubscribtion> MemberSubscribtion { set; get; }
        public virtual List<Attendence> Attendences { set; get; }
        public virtual List<PrivateCourseSubscriptions> courseSubscriptions { set; get; }
        public virtual List<PrivateCourseAttendance> CourseAttendances { set; get; }

    } 
}
