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
    public class PrivateCourseRepo
    {
        ApplicationContext _db;
        public PrivateCourseRepo()
        {
            _db = new ApplicationContext();
        }

        public void createCourse(PrivateCourseVm privateCourseVm)
        {
            PrivateCourse privateCourse = new PrivateCourse
            {
                name = privateCourseVm.name,
                price = privateCourseVm.price,
                sessions = privateCourseVm.sessions,
                duration = privateCourseVm.duration

            };
            _db.PrivateCourses.Add(privateCourse);
            _db.SaveChanges();
        }
        public void updatePrice(PrivateCourseVm privateCourseVm)
        {
            PrivateCourse privateCourse = _db.PrivateCourses.Find(privateCourseVm.id);
            privateCourse.price = privateCourseVm.price;
            _db.SaveChanges();
        }
        public void deleteById(PrivateCourseVm privateCourseVm)
        {
            PrivateCourse privateCourse = _db.PrivateCourses.Find(privateCourseVm.id);
            privateCourse.deleted = true;
            _db.SaveChanges();
        }
        public void resetById(PrivateCourseVm privateCourseVm)
        {
            PrivateCourse privateCourse = _db.PrivateCourses.Find(privateCourseVm.id);
            privateCourse.deleted = false;
            _db.SaveChanges();
        }
        public PrivateCourseVm GetCourse(PrivateCourseVm privateCourseVm)
        {
            PrivateCourse privateCourse = _db.PrivateCourses.Find(privateCourseVm.id);
            if (privateCourse != null)
            {
                PrivateCourseVm vm = new PrivateCourseVm
                {
                    id = privateCourse.id,
                    name = privateCourse.name,
                    deleted = privateCourse.deleted,
                    sessions = privateCourse.sessions,
                    duration = privateCourse.duration,
                    price = privateCourse.price
                };
                return vm;
            }
            else
            {
                throw new Exception("PrivateCourse not exists");
            }

        }
    }
}
