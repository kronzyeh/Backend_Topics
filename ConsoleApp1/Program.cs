using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            Increment(number1);
            Console.WriteLine(number1);
            RefIncrement(ref number1);
            Console.WriteLine(number1);
        }
        public static void Increment(int number)
        {
            number++;
        }
        public static void RefIncrement(ref int number)
        {
            number++;
        }
    }
}
