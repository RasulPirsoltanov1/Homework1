using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesgnPatternMemento.Memento
{
    internal class CareTaker
    {
        List<Memento>  mem=new List<Memento>();
        public List<Memento> Mem { get { return mem; } set { mem = value; } }
    }
}
