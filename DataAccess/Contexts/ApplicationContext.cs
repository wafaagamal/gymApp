using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Contexts
{
   public class ApplicationContext:DbContext
    {
        public ApplicationContext() : base("gymApp") { }
        public virtual DbSet<Member> Members { set; get; }
        public virtual DbSet<MemberShip> MemberShips { set; get; }
        public virtual DbSet<MemberSubscribtion> MemberSubscribtions { set; get; }
        public virtual DbSet<Attendence> Attendences { set; get; }
        public virtual DbSet<PrivateCourse> PrivateCourses { set; get; }
        public virtual DbSet<PrivateTrainer> PrivateTrainers { set; get; }
        public virtual DbSet<PrivateCourseAttendance> PrivateCourseAttendances { set; get; }
        public virtual DbSet<PrivateCourseSubscriptions> PrivateCourseSubscriptions { set; get; }
    }
}
