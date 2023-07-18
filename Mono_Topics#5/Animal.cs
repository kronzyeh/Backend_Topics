using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_5
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("ROAAAAR");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
