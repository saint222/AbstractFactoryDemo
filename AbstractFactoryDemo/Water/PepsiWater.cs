using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Water
{
    public class PepsiWater: AbstractWater
    {
        public PepsiWater(string name): base(name)
        {

        }
    }
}
