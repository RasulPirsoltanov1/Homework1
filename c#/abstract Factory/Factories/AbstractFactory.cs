using abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Factory.Factories
{
    public abstract class AbstractFactory
    {
        public abstract IShape getShape(string shapeName);
    }
}
