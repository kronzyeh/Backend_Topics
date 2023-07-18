using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics39
{
    public class Program
    {
        public static void Main(string[] args)
        {

            foreach(var num in GetEvenNumbers())
            {
                Console.WriteLine(num);
            }
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
        public static IEnumerable<int> GetEvenNumbers()
        {
            for(int i =0; i < 10; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    yield return i;
                }
            }
        }
    }
}
