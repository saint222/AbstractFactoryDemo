using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public abstract class AbstractBottle
    {
        public abstract void FillBottleWithWater(AbstractWater water);
    }
}
