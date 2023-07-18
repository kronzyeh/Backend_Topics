using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Display();
            Point point1 = new Point(10, 2);
            point1.Display();
        }
    }
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Coordinates: ({x}, {y})");
        }
    }


}
