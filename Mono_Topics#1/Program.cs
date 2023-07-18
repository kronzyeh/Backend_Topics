using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Name = "Audi";
            myCar.HorsePower = 105;
            Console.WriteLine(myCar.StartEngine());
        }
    }
}
