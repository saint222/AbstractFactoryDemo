using AbstractFactoryDemo.Bottle;
using AbstractFactoryDemo.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Factory
{
    public class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater("Pepsi");
        }
    }
}
