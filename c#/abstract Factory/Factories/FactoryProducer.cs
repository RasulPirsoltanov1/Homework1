using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Factory.Factories
{
    public static class FactoryProducer
    {
        public static AbstractFactory getFactory(bool facName)
        {
            if (facName)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
