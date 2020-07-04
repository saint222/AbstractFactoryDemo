using AbstractFactoryDemo.Bottle;
using AbstractFactoryDemo.Water;

namespace AbstractFactoryDemo.Factory
{
    public class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater("CocaCola");
        }
    }
}
