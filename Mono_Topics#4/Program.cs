using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.SumNumbers(2, 3));
            Console.WriteLine(calculator.SumNumbers(3, 4, 5));
            Console.WriteLine(calculator.SumNumbers(8, 4));
            Console.WriteLine(calculator.SumNumbers(10, 25, 33, 18));
        }
    }
}
