using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public class ManagerRepository : Repository<Manager>
    {
        public override event Action<Manager, Manager> managerChanged;

        public void ChangeTeam(Manager previousManager, Manager currentManager)
        {
            currentManager.Team = new List<Person>();

            foreach (var person in previousManager.Team)
            {
                currentManager.Team.Add(person);
            }
              
            //Invoke delegate and put data to it ~= entrance
            managerChanged?.Invoke(previousManager, currentManager);
        }
    }
}
