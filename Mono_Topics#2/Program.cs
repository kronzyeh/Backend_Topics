using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Abstract class
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine(rectangle.GetArea());

            // 2. Inheritance
            Lion lion = new Lion();
            lion.Name = "Lav";
            lion.Roar();
            Cow cow = new Cow();
            cow.Moo();

            // 3. Polymorphism
            lion.Breathe();
            cow.Breathe();
        }
    }
}
