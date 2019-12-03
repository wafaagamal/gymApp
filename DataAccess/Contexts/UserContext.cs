using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class ApplicationUser : IdentityUser
    {

    }

    public class UserContext : IdentityDbContext<ApplicationUser>
    {
        public UserContext()
            : base("gymApp", throwIfV1Schema: false)
        {
        }
    }

}
