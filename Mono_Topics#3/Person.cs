using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_3
{
    public class Person
    {
        private string Name
        {
            get; set;
        }
        private int Age;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public override string ToString()
        {
            return $"Person name is {Name} and he/she is {Age} years old";
        }
    }
}
