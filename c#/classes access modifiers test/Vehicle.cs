using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_access_modifiers_test
{
    public abstract class Vehicle
    {
        public void getStart()
        {
            Console.WriteLine("Vehicle is starting...");
        }
        public void getStop()
        {
            Console.WriteLine("Vehicle is stopping...");
        }
    }
}
