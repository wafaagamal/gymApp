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
    public class PrivateTrainerRepo
    {
        ApplicationContext _db;
        public PrivateTrainerRepo()
        {
            _db = new ApplicationContext();
        }

        public void createTrainer(PrivateTrainerVm privateTrainerVm)
        {
            PrivateTrainer privateTrainer = new PrivateTrainer
            {
                name = privateTrainerVm.name
            };
            _db.PrivateTrainers.Add(privateTrainer);
            _db.SaveChanges();
        }
        public void updateName(PrivateTrainerVm privateTrainerVm)
        {
            PrivateTrainer privateTrainer = _db.PrivateTrainers.Find(privateTrainerVm.id);
            privateTrainer.name = privateTrainerVm.name;
            _db.SaveChanges();
        }
        public void deleteById(PrivateTrainerVm privateTrainerVm)
        {
            PrivateTrainer privateTrainer = _db.PrivateTrainers.Find(privateTrainerVm.id);
            privateTrainer.deleted = true;
            _db.SaveChanges();
        }
        public void resetById(PrivateTrainerVm privateTrainerVm)
        {
            PrivateTrainer privateTrainer = _db.PrivateTrainers.Find(privateTrainerVm.id);
            privateTrainer.deleted = false;
            _db.SaveChanges();
        }
        public PrivateTrainerVm GetTrainer(PrivateTrainerVm privateTrainerVm)
        {
            PrivateTrainer privateTrainer = _db.PrivateTrainers.Find(privateTrainerVm.id);
            if (privateTrainer != null)
            {
                PrivateTrainerVm vm = new PrivateTrainerVm
                {
                    id = privateTrainer.id,
                    name = privateTrainer.name,
                    deleted = privateTrainer.deleted
                };
                return vm;
            }
            else
            {
                throw new Exception("PrivateTrainer not exists");
            }

        }

    }
}
