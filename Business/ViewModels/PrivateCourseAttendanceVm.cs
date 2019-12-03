﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels
{
    public class PrivateCourseAttendanceVm
    {
        public int id { set; get; }
        public DateTime date { set; get; }
        public int memberId { set; get; }
        public int courseId { set; get; }
        public int trainerId { set; get; }
        //public Member member { set; get; }
        //public PrivateTrainer privateTrainer { set; get; }
        //public PrivateCourse privateCourse { set; get; }
    }
}
