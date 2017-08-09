using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategySample.Ducks;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();

            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new GreenDuck());
            ducks.Add(new WoodDuck());

            foreach(var duck in ducks)
            {
                duck.Display();
                duck.Sweem();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
