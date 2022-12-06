using abstract_Factory.Figure;
using abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Factory.Factories
{
    internal class RoundedShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapeName)
        {
            if (shapeName=="rectangle")
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
