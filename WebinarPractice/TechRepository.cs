using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    class TechRepository : Repository<TechnicalSpecialist>
    {
        public List<TechnicalSpecialist> TechSpecialists { get; set; }      
        
        public void ChangeManager(Manager previousManager, Manager newManager)
        {
            foreach (var specialist in TechSpecialists)
            {
                if (specialist.Manager.Name == previousManager.Name)
                    specialist.Manager = newManager;
            }
        }
    }
}
