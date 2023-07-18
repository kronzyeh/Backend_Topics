using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_2
{
    public abstract class Shape
    {
        public abstract double GetArea();

    }
    public class Rectangle : Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
        
    }
}
