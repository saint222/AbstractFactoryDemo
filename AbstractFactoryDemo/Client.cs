using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        public Client(AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void RunProcess()
        {
            bottle.FillBottleWithWater(water);
        }
    }
}
