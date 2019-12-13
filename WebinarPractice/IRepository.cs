using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public interface IRepository<T>
    {
        event Action<Manager, Manager> managerChanged;
        void ReadData();
    }
}
