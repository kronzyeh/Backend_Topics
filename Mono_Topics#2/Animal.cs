using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_2
{
    public class Animal
    {
        public string Name { get; set; }
        public virtual void Breathe()
        {
            Console.WriteLine("Animal is breathing");
        }
    }

    public class Lion : Animal
    {
        public override void Breathe()
        {
            Console.WriteLine("The lion is breathing");
        }
        public void Roar()
        {
            Console.WriteLine($"The {this.Name} is roaring!");
        }
    }

    public class Cow : Animal
    {
        public void Moo()
        {
            Console.WriteLine("The cow is mooing!");
        }
    }
}
