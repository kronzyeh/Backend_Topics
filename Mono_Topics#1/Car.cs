using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_1
{
    public class Car
    {
        public string Name { get; set; }
        public int HorsePower { get; set; }
        public string StartEngine()
        {
            return "Engine turned on!";
        }
    }
}
