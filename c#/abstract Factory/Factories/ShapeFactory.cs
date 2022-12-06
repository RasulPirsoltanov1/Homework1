using abstract_Factory.Figure;
using abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Factory.Factories
{
    public class ShapeFactory:AbstractFactory
    {
        public override IShape getShape(string shapeName)
        {
            if (shapeName=="square")
            {
                return new Square();
            }
            return null;
        }
    }
}
