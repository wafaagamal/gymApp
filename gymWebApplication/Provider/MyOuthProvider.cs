using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.OAuth;
using System.Threading.Tasks;
using System.Security.Claims;
using Business.Repostories;
using Business.ViewModels;
using Utilities;

namespace gymWebApplication
{
    public class MyOuthProvider : OAuthAuthorizationServerProvider
    {

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();//to validate client outh later
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            //validate credintials and generate token
            UserRepo userRepo = new UserRepo();

            UserVm userVm = new UserVm
            {
                username = context.UserName,
                password = context.Password
            };
            UserVm user = userRepo.ValidateUser(userVm);
            if (user != null)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Role, user.role));
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid Credintional");
                return;
            }


        }

    }
}