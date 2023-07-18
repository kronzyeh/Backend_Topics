using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tomislav", "22");
            Console.WriteLine(person.ToString());
        }
    }
    public partial class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
    public partial class Person
    {
        public Person(string Name, string Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
    public partial class Person
    {
        public override string ToString()
        {
            return $"The winner is {Name} aged {Age}";
        }
    }
}
