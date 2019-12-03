using Business.ViewModels;
using DataAccess.Contexts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repostories
{
    public class PrivateCourseAttendanceRepo
    {
        ApplicationContext MyCtx;
        public PrivateCourseAttendanceRepo()
        {
            MyCtx = new ApplicationContext();
        }
        Task<PrivateCourseSubscriptions> supscriptionData(PrivateCourseAttendanceVm attObjs)
        {
            return MyCtx.PrivateCourseSubscriptions.Include("Member")
                .Where(ms => ms.member.id == attObjs.memberId && ms.member.sessions <= 10 &&
                ms.member.deleted == false &&
                DbFunctions.TruncateTime(ms.endDate).Value >= DateTime.Now).FirstOrDefaultAsync();
        }

        Task<PrivateCourse> courseData(PrivateCourseAttendanceVm attObjs)
        {
            return MyCtx.PrivateCourses.Where(ms => ms.id == attObjs.courseId &&
                ms.deleted == false).FirstOrDefaultAsync();
        }
        Task<PrivateTrainer> trainerData(PrivateCourseAttendanceVm attObjs)
        {
            return MyCtx.PrivateTrainers.Where(ms => ms.id == attObjs.trainerId &&
                ms.deleted == false).FirstOrDefaultAsync();
        }
        public async Task Create(PrivateCourseAttendanceVm attObjs)
        {

            var supscriptionTask = supscriptionData(attObjs);
            var courseTask = courseData(attObjs);
            var trainerTask = trainerData(attObjs);
            await Task.WhenAll(supscriptionTask, courseTask, trainerTask);

            // if (supscriptionTask.Result != null && courseTask.Result != null && trainerTask.Result != null)
            if (supscriptionTask != null && courseTask != null && trainerTask != null)
            {
                PrivateCourseAttendance Attendence = MyCtx.PrivateCourseAttendances.Include("Member")
                       .Where(e => e.member.id == attObjs.memberId &&
                       DbFunctions.DiffDays(e.date, DateTime.Now) <= 1).FirstOrDefault();
                if (Attendence != null)
                {
                    throw new Exception("invalid attendance date");
                }
                else
                {
                    PrivateCourseAttendance newAttendence = new PrivateCourseAttendance
                    {
                        date = DateTime.Now,

                    };


                    newAttendence.member = supscriptionTask.Result.member;
                    newAttendence.privateTrainer = trainerTask.Result;
                    newAttendence.privateCourse = courseTask.Result;
                    supscriptionTask.Result.member.sessions += 1;
                    supscriptionTask.Result.member.CourseAttendances = new List<PrivateCourseAttendance> { newAttendence };
                    // Console.WriteLine(newAttendence);
                    MyCtx.PrivateCourseAttendances.Add(newAttendence);
                    MyCtx.SaveChanges();
                }
            }
            else
            {
                throw new Exception("ERROR Supscription");
            }


        }


    }
}
