﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySample.Ducks
{
    public class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Я простая утка");
        }
    }
}
