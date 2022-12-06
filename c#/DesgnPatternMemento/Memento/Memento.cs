using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesgnPatternMemento.Memento
{
    internal class Memento
    {
        int state;
        public int State { get { return state; } set { state = value; } }
        public Memento(int state)
        {
            State = state; 
        }
    }
}
