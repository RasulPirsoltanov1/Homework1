using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesgnPatternMemento.Memento
{
    internal class Orginator
    {
        int state;
        public int State { get { return state; } set { state = value; } }
        public void SetMemento(Memento state)
        {
            this.state = state.State;
        }
        public List<Memento> CreateMemento(int state)
        {
            return new List<Memento>(state);
        }
        public void ReturnOldVersion(List<Memento> memento)
        {
            this.state = memento;
        }
    }
}


