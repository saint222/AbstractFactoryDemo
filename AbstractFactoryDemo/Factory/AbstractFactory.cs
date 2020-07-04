using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
    }
}
