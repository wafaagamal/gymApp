using Business.ViewModels;
using DataAccess.Contexts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repostories
{
    public class MemberRepo
    {
        ApplicationContext _db;
        public MemberRepo()
        {
            _db = new ApplicationContext();
        }
        public void CreateMember(MemberVm newMember)
        {
            MemberShip memberShip = _db.MemberShips.Find(newMember.memberShipId);
            Member member = new Member();
            MemberSubscribtion subscribtion = new MemberSubscribtion();
            PrivateCourseSubscriptions Coursesubscribtion = new PrivateCourseSubscriptions();
            if (memberShip != null)
            {
                if (newMember.courseId != 0)
                {
                    PrivateCourse privateCourse = _db.PrivateCourses.Find(newMember.courseId);

                    if (privateCourse != null)
                    {
                        member.name = newMember.name;
                        member.invitations = memberShip.invitations;
                        member.sessions = 0;

                        subscribtion.paid = true;
                        subscribtion.startTime = DateTime.Now;
                        subscribtion.endTime = DateTime.Now.AddDays(memberShip.duration);
                        subscribtion.discount = 10;
                        subscribtion.Member = member;
                        subscribtion.MemberShip = memberShip;

                        Coursesubscribtion.startDate = DateTime.Now;
                        Coursesubscribtion.endDate = DateTime.Now.AddDays(privateCourse.duration);
                        Coursesubscribtion.discount = 10;
                        Coursesubscribtion.member = member;
                        Coursesubscribtion.privateCourse = privateCourse;

                    }
                    else
                    {
                        throw new Exception("privateCourse not exists");
                    }
                }
                else
                {
                    member.name = newMember.name;
                    member.invitations = memberShip.invitations;


                    subscribtion.paid = true;
                    subscribtion.startTime = DateTime.Now;
                    subscribtion.endTime = DateTime.Now.AddDays(memberShip.duration);
                    subscribtion.discount = 10;
                    subscribtion.Member = member;
                    subscribtion.MemberShip = memberShip;
                }

                _db.Members.Add(member);
                _db.MemberSubscribtions.Add(subscribtion);
                _db.PrivateCourseSubscriptions.Add(Coursesubscribtion);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("membership not exists");
            }


        }
        public void deleteByid(int memberId)
        {
            Member member = _db.Members.Find(memberId);
            member.deleted = true;
            _db.SaveChanges();
        }
        public void resetByid(int memberId)
        {
            Member member = _db.Members.Find(memberId);
            member.deleted = false;
            _db.SaveChanges();
        }
        public void updateName(string name, int memberId)
        {
            Member member = _db.Members.Find(memberId);
            member.name = name;
            _db.SaveChanges();
        }
        public MemberVm GetMember(int memberId)
        {
            Member member = _db.Members.Find(memberId);
            if (member != null)
            {
                MemberVm vm = new MemberVm
                {
                    id = member.id,
                    name = member.name,
                    invitations = member.invitations,
                    sessions = member.sessions

                };
                return vm;
            }
            else
            {
                throw new Exception("member not exists");
            }

        }
        //public List<MemberVm> GetAllMember()
        //{
        //    List<Member> member = _db.Members.ToList();
        //    return null;//member;
        //}
    }
}
