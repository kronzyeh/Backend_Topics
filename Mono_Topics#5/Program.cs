﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Lion();
            lion.MakeSound();
            Animal cat = new Cat();
            cat.MakeSound();
        }
    }
}
