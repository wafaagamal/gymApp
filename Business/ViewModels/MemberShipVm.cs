﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels
{
    public class MemberShipVm
    {
        public int id { set; get; }
        public string name { set; get; }
        public int invitations { set; get; }
        public float price { set; get; }
        public int duration { set; get; }
        public bool deleted { set; get; }
    }
}
