using Business.Repostories;
using Business.ViewModels;
using System;

namespace gymApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcometo Gym System");
            Console.WriteLine("memberShip name ");
            string name = Console.ReadLine();
            Console.WriteLine("memberShip invitation ");
            int invitation = int.Parse(Console.ReadLine());
            Console.WriteLine("memberShip id ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("memberShip price ");
            float price = float.Parse(Console.ReadLine());
            MemberShipVm memberShipVm = new MemberShipVm()
            { id=id,
                name = name,
                invitations = invitation,
                price = price
            };
            MemberShipRepo re = new MemberShipRepo();
            Console.WriteLine(memberShipVm.id);
            re.Create(memberShipVm);
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
