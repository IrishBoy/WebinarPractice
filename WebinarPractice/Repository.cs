using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public class Repository<T> : IRepository<T>
    {
        public virtual event Action<Manager, Manager> managerChanged;
        public List<T> Items { get; set; }

        public void ReadData()
        {
            //some logic, i.e.:
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
