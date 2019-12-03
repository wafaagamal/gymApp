//using Business.Repostories;
//using Business.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace start
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcometo Gym System");
//            Console.WriteLine("enter m for Member");
//            Console.WriteLine("enter ms for MemberShip");
//            Console.WriteLine("enter att for Attendence");
//            Console.WriteLine("enter um for update member");
//            Console.WriteLine("enter ums for update membership");
//            Console.WriteLine("enter dm for delete member");
//            Console.WriteLine("enter dms for delete membership");

//            //string caseSwitch = Console.ReadLine();
            

//            //switch (caseSwitch)
//            //{
//            //    case "m":
              
//            //        Console.WriteLine("member name ");
//            //        string name = Console.ReadLine();
//            //        Console.WriteLine("membership id ");
//            //        int membershipid = int.Parse(Console.ReadLine());
//            //        MemberVm memberVm = new MemberVm()
//            //        {
//            //            name = name,
//            //        };
//            //        MemberRepo  memberRepo = new MemberRepo();
//            //        memberRepo.CreateMember(memberVm);
//            //        Console.WriteLine("done");
//            //        break;
//            //    case "ms":


//            //        Console.WriteLine("memberShip name ");
//            //        string name2 = Console.ReadLine();
//            //        Console.WriteLine("memberShip invitation ");
//            //        int invitation2 = int.Parse(Console.ReadLine());
//            //        Console.WriteLine("memberShip price ");
//            //        float price = float.Parse(Console.ReadLine());
//            //        Console.WriteLine("membership duration in days ");
//            //        int duration = int.Parse(Console.ReadLine());
//            //        MemberShipVm memberShipVm = new MemberShipVm
//            //        {
//            //            name = name2,
//            //            invitations = invitation2,
//            //            price = price,
//            //            duration=duration
//            //        };
//            //        MemberShipRepo memberShipRepo = new MemberShipRepo();
//            //        memberShipRepo.Create(memberShipVm);
//            //        Console.WriteLine("done");
//            //        break;

//            //    case "att":

//            //        Console.WriteLine("attendence invitation");
//            //        int invitation3 = int.Parse(Console.ReadLine());
//            //        Console.WriteLine("member id ");
//            //        int memberid = int.Parse(Console.ReadLine());
//            //        //Console.WriteLine("membership id ");
//            //        //int _membershipid = int.Parse(Console.ReadLine());
//            //        AttendenceVm attendenceVm = new AttendenceVm
//            //        {
//            //            invitations = invitation3
//            //        };
//            //        AttendenceRepo attendenceRepo = new AttendenceRepo();
//            //        attendenceRepo.Create(attendenceVm, memberid);
//            //        Console.WriteLine("done");
//            //        break;

//            //    case "um":

//            //        Console.WriteLine("member name ");
//            //        string updatedName = Console.ReadLine();
//            //        Console.WriteLine("member id ");
//            //        int memberid2 = int.Parse(Console.ReadLine());
//            //        MemberRepo memberRepo2 = new MemberRepo();
//            //        memberRepo2.updateName(updatedName, memberid2);
//            //        Console.WriteLine("done");

//            //        break;
//            //    case "ums":

//            //        Console.WriteLine("membership id ");
//            //        int membershipid2= int.Parse(Console.ReadLine());
//            //        Console.WriteLine("memberShip price ");
//            //        float price1 = float.Parse(Console.ReadLine());
//            //        MemberShipRepo membership = new MemberShipRepo();
//            //        membership.updatePrice(price1, membershipid2);
//            //        Console.WriteLine("done");
//            //        break;

//            //    case "dm":
//            //        Console.WriteLine("member id ");
//            //        int memberid3 = int.Parse(Console.ReadLine());
//            //        MemberRepo memberRepo3 = new MemberRepo();
//            //        memberRepo3.deleteByid(memberid3);
//            //        Console.WriteLine("done");
//            //        break;
//            //    case "dms":

//            //        Console.WriteLine("membership id ");
//            //        int membership3 = int.Parse(Console.ReadLine());
//            //        MemberShipRepo _membership = new MemberShipRepo();
//            //        _membership.deleteById(membership3);
//            //        Console.WriteLine("done");
//            //        break;

//            //    default:
//            //        Console.WriteLine("Default case");
//            //        break;
//            //}




//        }
//    }
//}
