using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public class TechnicalSpecialist : Person
    {
        public Manager Manager { get; set; }

        public TechnicalSpecialist(string name, DateTime birthDate) : base(name, birthDate) { }
    }
}
