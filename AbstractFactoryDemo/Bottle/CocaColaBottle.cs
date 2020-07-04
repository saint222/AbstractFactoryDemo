using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Bottle
{
    public class CocaColaBottle : AbstractBottle
    {
        public override void FillBottleWithWater(AbstractWater water)
        {
            Console.WriteLine($"The process of filling bottles with {water.Name} has been started...");
        }
    }
}
