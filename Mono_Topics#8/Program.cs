using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 42;
            object BoxedNumber = number;
            Console.WriteLine(BoxedNumber);
            Console.WriteLine(number);
            int UnboxedNumber = (int)BoxedNumber;
            Console.WriteLine(UnboxedNumber);
        }
    }
}
