using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels
{
    public class UserVm
    {
        public string id { set; get; }
        public string username { set; get; }
        public string email { set; get; }
        public string role { set; get; }
        public string password { set; get; }
    }
}
