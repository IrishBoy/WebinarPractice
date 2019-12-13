using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public class Manager : Person
    {
        public List<Person> Team { get; set; }

        public Manager(string name, DateTime birthDate) : base(name, birthDate) { }
    }
}
