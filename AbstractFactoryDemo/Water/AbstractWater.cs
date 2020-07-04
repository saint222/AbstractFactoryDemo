using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    public abstract class AbstractWater
    {
        public AbstractWater(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
