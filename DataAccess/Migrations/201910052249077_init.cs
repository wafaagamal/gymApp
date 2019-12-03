namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendences",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        time = c.DateTime(nullable: false),
                        invitations = c.Int(nullable: false),
                        member_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Members", t => t.member_id)
                .Index(t => t.member_id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        invitations = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        sessions = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PrivateCourseAttendances",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        member_id = c.Int(),
                        privateCourse_id = c.Int(),
                        privateTrainer_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Members", t => t.member_id)
                .ForeignKey("dbo.PrivateCourses", t => t.privateCourse_id)
                .ForeignKey("dbo.PrivateTrainers", t => t.privateTrainer_id)
                .Index(t => t.member_id)
                .Index(t => t.privateCourse_id)
                .Index(t => t.privateTrainer_id);
            
            CreateTable(
                "dbo.PrivateCourses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(nullable: false),
                        duration = c.Int(nullable: false),
                        sessions = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PrivateCourseSubscriptions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        discount = c.Int(nullable: false),
                        member_id = c.Int(),
                        privateCourse_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Members", t => t.member_id)
                .ForeignKey("dbo.PrivateCourses", t => t.privateCourse_id)
                .Index(t => t.member_id)
                .Index(t => t.privateCourse_id);
            
            CreateTable(
                "dbo.PrivateTrainers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MemberSubscribtions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        discount = c.Single(nullable: false),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        paid = c.Boolean(nullable: false),
                        Member_id = c.Int(),
                        MemberShip_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Members", t => t.Member_id)
                .ForeignKey("dbo.MemberShips", t => t.MemberShip_id)
                .Index(t => t.Member_id)
                .Index(t => t.MemberShip_id);
            
            CreateTable(
                "dbo.MemberShips",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        duration = c.Int(nullable: false),
                        name = c.String(),
                        invitations = c.Int(nullable: false),
                        price = c.Single(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberSubscribtions", "MemberShip_id", "dbo.MemberShips");
            DropForeignKey("dbo.MemberSubscribtions", "Member_id", "dbo.Members");
            DropForeignKey("dbo.PrivateCourseAttendances", "privateTrainer_id", "dbo.PrivateTrainers");
            DropForeignKey("dbo.PrivateCourseAttendances", "privateCourse_id", "dbo.PrivateCourses");
            DropForeignKey("dbo.PrivateCourseSubscriptions", "privateCourse_id", "dbo.PrivateCourses");
            DropForeignKey("dbo.PrivateCourseSubscriptions", "member_id", "dbo.Members");
            DropForeignKey("dbo.PrivateCourseAttendances", "member_id", "dbo.Members");
            DropForeignKey("dbo.Attendences", "member_id", "dbo.Members");
            DropIndex("dbo.MemberSubscribtions", new[] { "MemberShip_id" });
            DropIndex("dbo.MemberSubscribtions", new[] { "Member_id" });
            DropIndex("dbo.PrivateCourseSubscriptions", new[] { "privateCourse_id" });
            DropIndex("dbo.PrivateCourseSubscriptions", new[] { "member_id" });
            DropIndex("dbo.PrivateCourseAttendances", new[] { "privateTrainer_id" });
            DropIndex("dbo.PrivateCourseAttendances", new[] { "privateCourse_id" });
            DropIndex("dbo.PrivateCourseAttendances", new[] { "member_id" });
            DropIndex("dbo.Attendences", new[] { "member_id" });
            DropTable("dbo.MemberShips");
            DropTable("dbo.MemberSubscribtions");
            DropTable("dbo.PrivateTrainers");
            DropTable("dbo.PrivateCourseSubscriptions");
            DropTable("dbo.PrivateCourses");
            DropTable("dbo.PrivateCourseAttendances");
            DropTable("dbo.Members");
            DropTable("dbo.Attendences");
        }
    }
}
