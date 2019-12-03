using Business.ViewModels;
using DataAccess.Contexts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace Business.Repostories
{

    public class AttendenceRepo
    {
        ApplicationContext _db;
        public AttendenceRepo()
        {
            _db = new ApplicationContext();
        }

        public void Create(AttendenceVm attObjs)
        {
            if (attObjs.invitations <= 2 && attObjs.invitations != 0)
            {

                MemberSubscribtion memberSubscribtion = _db.MemberSubscribtions.Include("Member")
                    .Where(ms => ms.Member.id == attObjs.memberId && ms.Member.invitations >= attObjs.invitations &&
                    ms.Member.deleted == false &&
                    DbFunctions.TruncateTime(ms.endTime).Value >= DateTime.Now).FirstOrDefault();

                if (memberSubscribtion != null)
                {
                    Attendence memberAttendence = _db.Attendences.Include("Member")
                        .Where(e => e.member.id == attObjs.memberId && DbFunctions.DiffDays(e.time, DateTime.Now) <= 1).FirstOrDefault();
                    if (memberAttendence != null)
                    {
                        throw new Exception("invalid Date");
                    }
                    else
                    {
                        Attendence attendence = new Attendence
                        {
                            invitations = attObjs.invitations,
                            time = DateTime.Now,

                        };
                        attendence.member = memberSubscribtion.Member;
                        memberSubscribtion.Member.invitations -= attObjs.invitations;
                        memberSubscribtion.Member.Attendences = new List<Attendence> { attendence };
                        _db.Attendences.Add(attendence);
                        _db.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("invalid member Subscribtion");
                }
            }
            else
            {
                throw new Exception("invalid number of invitations");
            }

        }

    }
}
