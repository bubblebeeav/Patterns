using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySample.Ducks
{
    public abstract class DuckBase
    {
        public void Sweem()
        {
            Console.WriteLine("Я плаваю");
        }

        public void Quack()
        {
            Console.WriteLine("Кря Кря");
        }

        public void Fly()
        {
            Console.WriteLine("Я летаю");
        }

        public abstract void Display();
    }
}
