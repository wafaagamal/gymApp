using Business.ViewModels;
using DataAccess.Contexts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repostories
{
    public class MemberShipRepo
    {
        ApplicationContext _db;
        public MemberShipRepo()
        {
            _db = new ApplicationContext();
        }
        public void Create(MemberShipVm mShip)
        {
            var memShip = new MemberShip
            {
                name = mShip.name,
                price = mShip.price,
                invitations = mShip.invitations,
                duration = mShip.duration

            };
            _db.MemberShips.Add(memShip);
            _db.SaveChanges();
        }
        public void updatePrice(float price, int memberShipId)
        {
            MemberShip memberShip = _db.MemberShips.Find(memberShipId);
            memberShip.price = price;
            _db.SaveChanges();

        }
        public void deleteById(int memberShipId)
        {
            MemberShip memberShip = _db.MemberShips.Find(memberShipId);
            memberShip.deleted = true;
            _db.SaveChanges();

        }
        public void resetById(int memberShipId)
        {
            MemberShip memberShip = _db.MemberShips.Find(memberShipId);
            memberShip.deleted = false;
            _db.SaveChanges();

        }
        public MemberShipVm GetMemberShip(int memberShipId)
        {
            MemberShip memberShip = _db.MemberShips.Find(memberShipId);
            if (memberShip != null)
            {
                MemberShipVm vm = new MemberShipVm
                {
                    id = memberShip.id,
                    name = memberShip.name,
                    invitations = memberShip.invitations,
                    price = memberShip.price,
                    duration = memberShip.duration,
                    deleted = memberShip.deleted


                };
                return vm;
            }
            else
            {
                throw new Exception("memberShip not exists");
            }

        }
        //public List<MemberShipVm> GetAllMemberShip()
        //{
        //    List<MemberShipVm> memberShips = _db.MemberShips.ToList();
        //    return memberShip;
        //}

    }
}
