namespace DataAccess.Migrations
{
    using DataAccess.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Utilities;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Contexts.ApplicationContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.Contexts.ApplicationContext context)
        {
           
            
            IList<MemberShip> memberShip = new List<MemberShip>();
            memberShip.Add(new MemberShip()
            {
                name = "gold",
                price = 4000,
                invitations = 5,
                duration = 15
            });
            context.MemberShips.AddRange(memberShip);


            IList<PrivateCourse> privateCourse = new List<PrivateCourse>();
            privateCourse.Add(new PrivateCourse()
            {
                name = "specialCourse",
                price = 5000,
                duration = 30,
                sessions = 10
            });
            context.PrivateCourses.AddRange(privateCourse);

            base.Seed(context);
        }
    }
}
