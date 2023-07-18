using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isSumEven = (x, y) => (x + y) % 2 == 0;
            var result = isSumEven(6, 10);
            Console.WriteLine(result);

            Action<string> writeMessage = message => Console.WriteLine(message);
            writeMessage("Hello, its me");
            Console.ReadKey();
        }
    }
}
