using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<TechnicalSpecialist> techRepo = new TechRepository();
            IRepository<Manager>mgmtRepo = new ManagerRepository();

            //link delegate to the method, define ~= exit
            mgmtRepo.managerChanged += ((TechRepository)techRepo).ChangeManager;
        }
    }
}
