using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDay = birthDate;
        }
    }
}
