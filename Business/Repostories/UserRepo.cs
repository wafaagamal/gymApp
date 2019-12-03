using DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Business.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using static Business.Repostories.ApplicationUserManager;
using Microsoft.AspNet.Identity.Owin;
using System.Diagnostics;

namespace Business.Repostories
{
    public class UserRepo 
    {
        UserStore<ApplicationUser> Store = new UserStore<ApplicationUser>(new UserContext());
        ApplicationUserManager userManager;
        RoleManager<IdentityRole> roleManager;
        public UserRepo()
        {
            userManager = new ApplicationUserManager(Store);
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new UserContext()));
        }
     
        //ApplicationSignInManager _signInManager;
        public void AddUser(UserVm userVm)
        {
            ApplicationUser user= new ApplicationUser() { UserName = userVm.username, Email = userVm.email ,PasswordHash=userVm.password}; 
            var result = userManager.Create(user,userVm.password);
            if (!result.Succeeded)
            {
                throw new Exception("already exists");
            }
            else
            {
                if (!roleManager.RoleExists("receptionist"))
                {
                    var role = new IdentityRole();
                    role.Name = "receptionist";
                    roleManager.Create(role);

                }
                userManager.AddToRole(user.Id,userVm.role);
                Debug.WriteLine("Success");
            }
            
        }
        //public SignInStatus Login(UserVm userVm)
        //{
        //    var result = _signInManager.PasswordSignIn(userVm.email, userVm.password,false, shouldLockout: false);
        //    return result;
        //}
        public UserVm FindUser(UserVm userVm)
        {

            IdentityUser User = userManager.FindByEmail(userVm.email);
            if (User != null)
            {
                var Role = userManager.GetRoles(User.Id);
                UserVm user = new UserVm
                {
                    id = User.Id,
                    email = User.Email,
                    username = User.UserName,
                    role=Role[0]
                };

                return user;
            }
            else
            {
                throw new Exception("email not Exists");
            }
          
        }
        public UserVm ValidateUser(UserVm userVm)
        {
            var User =userManager.Find(userVm.username,userVm.password);
            if (User != null)
            {
                var Role = userManager.GetRoles(User.Id);
                UserVm user = new UserVm
                {
                    email = User.Email,
                    username = User.UserName,
                    role = Role[0]
                };
                return user;
            }
            else
            {
                throw new Exception("invalid credintional");
            }
        }
    }
}
